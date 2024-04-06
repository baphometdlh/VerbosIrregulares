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
        //nuevo
        private HashSet<int> usedIndices;
        private int totalVerbs;
        private int verbsShown;

        public Verbos()
        {
            InitializeComponent();
            InitializeExcel();
            LoadVerbs();
            random = new Random();
            //nuevo
            usedIndices = new HashSet<int>();
            totalVerbs = verbs.Count;
            verbsShown = 0;
            labelTotal.Text = "Cantidad total de verbos: " + totalVerbs.ToString();
            labelCantidadVerbos.Text = "0";
            labelCantidadAciertos.Text = "0";
            labelCantidadFallos.Text = "0";
        }

        private void InitializeExcel()
        {
            try
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

                    for (int row = 2; row <= rowCount; row++)
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
            catch (Exception e)
            {

                MessageBox.Show("algún problema cargando el excel: " + e.Message);
            }

        }

        private void LoadVerbs()
        {
            // Carga los verbos desde el archivo Excel
            // Implementación ya realizada en InitializeExcel()
        }

        private void ShowRandomVerb()
        {
            try
            {
                // Muestra un verbo aleatorio que no se haya mostrado antes
                int randomIndex = random.Next(totalVerbs);
                while (usedIndices.Contains(randomIndex))
                {
                    randomIndex = random.Next(totalVerbs);
                }
                usedIndices.Add(randomIndex);

                Verb currentVerb = verbs[randomIndex];
                lblVerb.Text = currentVerb.Infinitive;
                verbsShown++;
                labelCantidadVerbos.Text = verbsShown.ToString();

                if (verbsShown >= totalVerbs)
                {
                    ShowResult();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Problema a la hora de mostrar un verbo: " +  e.Message);
            }

        }

        private void ShowResult()
        {
            // Muestra el resultado del juego y cierra la aplicación
            MessageBox.Show($"Palabras intentadas: {correctAnswers + incorrectAnswers}\n" +
                            $"Respuestas correctas: {correctAnswers}\n" +
                            $"Respuestas incorrectas: {incorrectAnswers}");
            this.Close();
        }

        private void CheckAnswers()
        {
            try
            {
                // Verifica si ambas respuestas del usuario son correctas
                Verb currentVerb = verbs.FirstOrDefault(v => v.Infinitive == lblVerb.Text);

                if (currentVerb != null)
                {
                    bool simplePastCorrect = txtAnswer.Text.ToLower() == currentVerb.SimplePast.ToLower();
                    bool meaningCorrect = txtMeaning.Text.ToLower() == currentVerb.Meaning.ToLower();

                    if (simplePastCorrect && meaningCorrect)
                    {
                        MessageBox.Show("¡Ambas respuestas son correctas!");
                        correctAnswers++;
                        labelCantidadAciertos.Text = correctAnswers.ToString();
                        attempts = 0;
                        if (verbsShown <= totalVerbs)
                        {
                            ShowRandomVerb();
                        }
                        else
                        {
                            ShowResult();
                        }
                        ClearTextFields();
                    }
                    else
                    {
                        attempts++;
                        if (attempts == 3)
                        {
                            MessageBox.Show($"Respuestas incorrectas. La respuesta correcta es: {currentVerb.SimplePast} - {currentVerb.Meaning}");
                            incorrectAnswers++;
                            labelCantidadFallos.Text = incorrectAnswers.ToString();
                            attempts = 0;
                            if (verbsShown <= totalVerbs)
                            {
                                ShowRandomVerb();
                            }
                            else
                            {
                                ShowResult();
                            }
                            //ShowRandomVerb();
                            ClearTextFields();
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                            ClearTextFields();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema a la hora de verificar las respuestas: " + e.Message);
            }
            

        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            // Comienza el cuestionario
            btnStart.Enabled = false;
            txtAnswer.Enabled = true;
            txtMeaning.Enabled = true;
            btnFinish.Enabled = true;
            ShowRandomVerb();
            lblVerb.Visible = true;
            btnStart.Enabled = true;
            txtMeaning.Focus();
        }

        private void btnFinish_Click_1(object sender, EventArgs e)
        {
            // Muestra el resumen y cierra la aplicación
            ShowResult();
        }

        private void txtAnswer_KeyDown_1(object sender, KeyEventArgs e)
        {
            // Verifica la respuesta del usuario cuando presiona Enter
            if (e.KeyCode == Keys.Enter)
            {
                CheckAnswers();
                txtMeaning.Focus();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
