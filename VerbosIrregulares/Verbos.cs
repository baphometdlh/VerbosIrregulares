using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;

namespace VerbosIrregulares
{
    public partial class Verbos : System.Windows.Forms.Form
    {
        private List<Verb> verbs;
        private Random random;
        private int currentVerbIndex;
        private int attempts;
        private int correctAnswers;
        private int incorrectAnswers;

        public Verbos()
        {
            InitializeComponent();
            InitializeExcel();
            LoadVerbs();
            random = new Random();
        }

        private void InitializeExcel()
        {

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Abre el archivo Excel usando EPPlus
            string excelPath = @"..\..\..\excel\verbosIrregulares.xlsx";
            FileInfo excelFile = new FileInfo(excelPath);
            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["COMPLETO"];
                int rowCount = worksheet.Dimension.Rows;
                verbs = new List<Verb>();

                for (int row = 2; row <= 46; row++)
                {
                    Verb verb = new Verb
                    {
                        Infinitive = worksheet.Cells[row, 1].Value.ToString(),
                        SimplePast = worksheet.Cells[row, 2].Value.ToString(),
                        PastParticiple = worksheet.Cells[row, 3].Value.ToString(),
                        Meaning = worksheet.Cells[row, 4].Value.ToString()
                    };
                    verbs.Add(verb);
                }
            }
        }

        private void LoadVerbs()
        {
            // Carga los verbos desde el archivo Excel
            // Implementación ya realizada en InitializeExcel()
        }

        private void ShowRandomVerb()
        {
            // Muestra un verbo aleatorio en la etiqueta lblVerb
            currentVerbIndex = random.Next(verbs.Count);
            lblVerb.Text = verbs[currentVerbIndex].Infinitive;
        }

        private void CheckAnswer(string answer)
        {
            // Verifica si ambas respuestas del usuario son correctas
            Verb currentVerb = verbs[currentVerbIndex];
            bool simplePastCorrect = txtAnswer.Text.ToLower() == currentVerb.SimplePast.ToLower();
            bool meaningCorrect = txtMeaning.Text.ToLower() == currentVerb.Meaning.ToLower();

            if (simplePastCorrect && meaningCorrect)
            {
                MessageBox.Show("¡Ambas respuestas son correctas!");
                correctAnswers++;
                attempts = 0;
                ShowRandomVerb();
                ClearTextFields();
                txtMeaning.Focus();
            }
            else
            {
                attempts++;
                if (attempts == 3)
                {
                    MessageBox.Show($"Respuestas incorrectas. La respuesta correcta es: {currentVerb.SimplePast} - {currentVerb.Meaning}");
                    incorrectAnswers++;
                    attempts = 0;
                    ShowRandomVerb();
                    ClearTextFields();
                    txtMeaning.Focus();
                }
                else
                {
                    MessageBox.Show("ERROR");
                    ClearTextFields();
                    txtMeaning.Focus();
                }
            }
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            // Comienza el cuestionario
            ShowRandomVerb();
            btnStart.Enabled = false;
            txtAnswer.Enabled = true;
            txtAnswer.Visible = true;
            txtMeaning.Enabled = true;
            btnFinish.Enabled = true;
            lblVerb.Visible = true;
        }

        private void btnFinish_Click_1(object sender, EventArgs e)
        {
            // Muestra el resumen y cierra la aplicación
            MessageBox.Show($"Palabras intentadas: {correctAnswers + incorrectAnswers}\n" +
                            $"Respuestas correctas: {correctAnswers}\n" +
                            $"Respuestas incorrectas: {incorrectAnswers}");
            this.Close();
        }

        private void txtAnswer_KeyDown_1(object sender, KeyEventArgs e)
        {
            // Verifica la respuesta del usuario cuando presiona Enter
            if (e.KeyCode == Keys.Enter)
            {
                CheckAnswer(txtAnswer.Text);
            }
        }

        private void txtMeaning_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAnswer.Focus();
            }
        }

        private void ClearTextFields()
        {
            // Limpia los TextBox
            txtAnswer.Clear();
            txtMeaning.Clear();
        }
    }

    public class Verb
    {
        // Modelo de datos para los verbos
        public string Infinitive { get; set; }
        public string SimplePast { get; set; }
        public string PastParticiple { get; set; }
        public string Meaning { get; set; }
    }
}
