using System;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace USB_Camera
{
    public partial class MainForm : Form
    {
        private CascadeClassifier _faceDetector;
        private EigenFaceRecognizer _recognizer;
        private VectorOfMat _trainingFaces;
        private VectorOfInt _trainingLabels;

        public MainForm()
        {
            InitializeComponent();

            // Initialize components for face detection and recognition
            _faceDetector = new CascadeClassifier("haarcascade_frontalface_default.xml");
            _recognizer = new EigenFaceRecognizer();
            _trainingFaces = new VectorOfMat();
            _trainingLabels = new VectorOfInt();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath;
                    TrainRecognizer(selectedFolder);
                }
            }
        }

        private void TrainRecognizer(string folderPath)
        {
            try
            {
                _trainingFaces.Clear();
                _trainingLabels.Clear();

                var subfolders = Directory.GetDirectories(folderPath);
                foreach (var folder in subfolders)
                {
                    string folderName = new DirectoryInfo(folder).Name;
                    if (int.TryParse(folderName, out int label))
                    {
                        foreach (var file in Directory.GetFiles(folder, "*.png"))
                        {
                            Mat image = CvInvoke.Imread(file, ImreadModes.Grayscale);
                            _trainingFaces.Push(image);
                            _trainingLabels.Push(new[] { label });
                        }
                    }
                }

                if (_trainingFaces.Size > 0)
                {
                    _recognizer.Train(_trainingFaces, _trainingLabels);
                    lstLog.Items.Add("Training completed.");
                    MessageBox.Show("Training completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lstLog.Items.Add("No training images found.");
                    MessageBox.Show("No images found for training.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                lstLog.Items.Add($"Training error: {ex.Message}");
                MessageBox.Show($"Error during training: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSnapshot_Click(object sender, EventArgs e)
        {
            Mat frame = CaptureFrame();
            if (frame != null)
            {
                DetectAndRecognizeFaces(frame);
            }
        }

        private Mat CaptureFrame()
        {
            using (VideoCapture capture = new VideoCapture(0))
            {
                Mat frame = new Mat();
                capture.Read(frame);

                if (!frame.IsEmpty)
                {
                    pbLiveFeed.Image = frame.ToBitmap();
                    return frame;
                }
                else
                {
                    MessageBox.Show("Could not capture frame from camera.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private void DetectAndRecognizeFaces(Mat frame)
        {
            try
            {
                Mat grayFrame = new Mat();
                CvInvoke.CvtColor(frame, grayFrame, ColorConversion.Bgr2Gray);

                var faces = _faceDetector.DetectMultiScale(grayFrame, 1.1, 10, new System.Drawing.Size(50, 50), System.Drawing.Size.Empty);
                foreach (var face in faces)
                {
                    Mat detectedFace = new Mat(grayFrame, face);
                    CvInvoke.Resize(detectedFace, detectedFace, new System.Drawing.Size(100, 100));

                    // Recognize the face
                    var prediction = _recognizer.Predict(detectedFace);
                    string result = prediction.Label > -1 ? $"Recognized ID: {prediction.Label}" : "Unknown";

                    lstLog.Items.Add(result);
                    pbDetectedFace.Image = detectedFace.ToBitmap();
                }

                lstLog.Items.Add($"{faces.Length} face(s) detected.");
            }
            catch (Exception ex)
            {
                lstLog.Items.Add($"Face detection error: {ex.Message}");
                MessageBox.Show($"Error detecting faces: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
