using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ArinaWebsiteManager
{
    public partial class MainForm : Form
    {
        public string WebsitePath = @"C:\Programs\ArinaWebsiteManager\ArinaOrganization\";
        public string WebsiteUrl = @"http://www.arinawebsite.org";
        public string BackupPath = @"E:\Backup\WebSite\ArinaOrganization\";
        public string CurrentModule = "";
        public List<Person> data;
        public List<BestowRecord> records;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            //foreach(Person p in data)
            //{
            //    p.SurnameFirst = "y";
            //}


            //records.Clear();
            //foreach (Person p in data)
            //{
            //    //if(p.LastBestowDate == "10/25/03")
            //    //    p.LastBestowDate = DateTime.Parse("2020/10/25").Date.AddYears(-2017).ToShortDateString();
            //    //else                
            //    BestowRecord br = new BestowRecord(p.ID);
            //    br.BestowDateTime = DateTime.Now.AddYears(-2017).ToString();
            //    br.MoralRank = p.MoralRank;
            //    p.LastBestowDate = DateTime.Parse(br.BestowDateTime).ToShortDateString();
            //    records.Add(br);
            //}


            //data.Add(new Person { Name = "陳其邁", ID = Guid.NewGuid().ToString(), Gender = "m" });

            //foreach(Person p in data)
            //{
            //    if (p.From == "歴史人物")
            //        p.From = "歷史人物";

            //}

            //using (FileStream dataFile = File.Open(string.Concat(WebsitePath, "ArinaQuotes.txt"), FileMode.Open))
            //{
            //    dataFile.Position = 0;
            //    using (FileStream outputFile = File.Create(string.Concat(WebsitePath, "Quotes.json")))
            //    {
            //        StreamReader sr = new StreamReader(dataFile);
            //        StreamWriter sw = new StreamWriter(outputFile);
            //        string s = "";
            //        string[] date;
            //        int index = 1, peek;
            //        sw.Write("[");
            //        while (!sr.EndOfStream)
            //        {
            //            if (index != 1)
            //                sw.Write(",");
            //            sw.Write("{");
            //            sw.Write("\"No\":" + index + ",");
            //            s = sr.ReadLine();
            //            while (s == "")
            //                s = sr.ReadLine();
            //            if (s != "-")
            //            {
            //                date = s.Split(',');
            //                s = string.Format("{0:0000}/{1:00}/{2:00}", Convert.ToInt32(date[2].Trim().Substring(3)), Convert.ToInt32(date[0]), Convert.ToInt32(date[1]));
            //            }
            //            sw.Write("\"Date\":\"" + s + "\",");

            //            s = "";
            //            peek = sr.Peek();
            //            while (peek < 'A' || peek > 'z' || peek == 13 || peek == 10)
            //            {
            //                s += sr.ReadLine();
            //                peek = sr.Peek();
            //            }
            //            s = s.Replace("\"", "\\\"");
            //            sw.Write("\"Chinese\":\"" + s + "\",");

            //            s = "";
            //            peek = sr.Peek();
            //            while (peek >= 'A' && peek <= 'z' || peek == 13 || peek == 10 || peek == '\"')
            //            {
            //                s += sr.ReadLine();
            //                peek = sr.Peek();
            //            }
            //            s = s.Replace("\"", "\\\"");
            //            sw.Write("\"English\":\"" + s + "\",");

            //            sw.Write("\"Japneses\":\"\"");

            //            sw.Write("}");
            //            index++;
            //        }
            //        sw.Write("]");
            //        sr.Close();
            //        sw.Close();
            //    }
            //}
            //MessageBox.Show("Complete");
        }

        private void btnProduceJS_Click(object sender, EventArgs e)
        {
            using (FileStream outputFile = File.Open(string.Concat(WebsitePath, "LastUpdate.json"), FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(outputFile))
                {
                    sw.WriteLine($"[{{ \"LastUpdate\": \"{DateTime.Now.Date.AddYears(-2017).ToString("M, d, Ar.y")}\" }}]");
                }
            }
            tslMain.Text = "LastUpdate File Created.";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            CurrentModule = typeof(Person).ToString();
            using (FileStream dataFile = File.Open(string.Concat(WebsitePath, "Persons.json"), FileMode.Open))
            {
                dataFile.Position = 0;
                StreamReader sr = new StreamReader(dataFile);
                data = JsonConvert.DeserializeObject<List<Person>>(sr.ReadToEnd());
            }

            using (FileStream dataFile = File.Open(string.Concat(WebsitePath, "BestowRecords.json"), FileMode.Open))
            {
                dataFile.Position = 0;
                StreamReader sr = new StreamReader(dataFile);
                records = JsonConvert.DeserializeObject<List<BestowRecord>>(sr.ReadToEnd());
            }

            RefreshEditArea();
            RefreshInfoList();

            tslMain.Text = "Data Loaded.";
        }

        private void lbxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnlEditArea.Controls.Count == 0)
                return;
            PropertyInfo[] pis = Type.GetType(CurrentModule).GetProperties();
            foreach (PropertyInfo pi in pis)
            {
                TextBox tb = pnlEditArea.Controls.Find(string.Concat("txt", pi.Name), false)[0] as TextBox;
                if (tb == null)
                {
                    MessageBox.Show("Wrong!");
                    return;
                }
                if (CurrentModule == typeof(Person).ToString())
                    tb.Text = pi.GetValue(data[lbxInfo.SelectedIndex]).ToString();
                else
                    tb.Text = pi.GetValue(records[lbxInfo.SelectedIndex]).ToString();
            }
            if (lbxInfo.SelectedIndex != -1 && CurrentModule == typeof(Person).ToString())
                btnAddRecord.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
                return;
            using (FileStream outputFile = File.Open(string.Concat(WebsitePath, "Persons.json"), FileMode.Create))
            {
                outputFile.Position = 0;
                StreamWriter sw = new StreamWriter(outputFile);
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                sw.Write(json);
                sw.Close();
            }
            tslMain.Text = "Person Data Saved.";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TextBox tb;
            foreach (Control c in pnlEditArea.Controls)
            {
                if (c as TextBox == null)
                    continue;
                tb = c as TextBox;
                PropertyInfo pi = Type.GetType(CurrentModule).GetProperty(tb.Name.Substring(3));
                if (CurrentModule == typeof(Person).ToString())
                {
                    pi.SetValue(data[lbxInfo.SelectedIndex], Convert.ChangeType(tb.Text, pi.PropertyType));

                }
                else
                {
                    pi.SetValue(records[lbxInfo.SelectedIndex], Convert.ChangeType(tb.Text, pi.PropertyType));

                }
            }
            if (CurrentModule == typeof(BestowRecord).ToString())
            {
                UpdatePersonData(records[lbxInfo.SelectedIndex].PersonID);
                btnShowPersonData_Click(this, e);
            }
            else
            {
                RefreshInfoList();
            }

            tslMain.Text = "Data Updated.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlEditArea.Controls)
                if (c as TextBox != null)
                    ((TextBox)c).Text = "";
            tslMain.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Type.GetType(CurrentModule) == typeof(Person))
            {
                Person p = new Person();
                data.Add(p);
                lbxInfo.Items.Add(0);
            }
            else
            {
                BestowRecord br = new BestowRecord();
                records.Add(br);
                lbxInfo.Items.Add(string.Concat(br.BestowDateTime, "  ", br.PersonID.Substring(6), "  ", br.MoralRank));
            }
            lbxInfo.SelectedIndex = lbxInfo.Items.Count - 1;
            tslMain.Text = "Item Added.";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
                return;

            if (Type.GetType(CurrentModule) == typeof(Person))
            {
                records.RemoveAll(m => m.PersonID == data[lbxInfo.SelectedIndex].ID);
                data.RemoveAt(lbxInfo.SelectedIndex);
            }
            else
            {
                string personID = records[lbxInfo.SelectedIndex].PersonID;
                records.RemoveAt(lbxInfo.SelectedIndex);
                UpdatePersonData(personID);
            }
            RefreshInfoList();
            tslMain.Text = "Item Removed.";
        }

        private void RefreshInfoList()
        {
            string fullname = "";
            int Index = lbxInfo.SelectedIndex;

            if (Type.GetType(CurrentModule) == typeof(Person))
            {
                data = data.OrderByDescending(m => m.MoralRank)
                           .ThenByDescending(m => m.Gender)
                           .ThenBy(m => m.Fiction)
                           .ThenByDescending(m => m.From)
                           .ThenByDescending(m => m.Wanted)
                           .ThenByDescending(m => m.Surname)
                           .ThenByDescending(m => m.Name)
                           .ToList();

                lbxInfo.Items.Clear();


                foreach (Person p in data)
                {
                    if (p.SurnameFirst == "y")
                        fullname = string.Concat(p.Surname, p.Name);
                    else
                        fullname = string.Concat(p.Name, ".", p.Surname);
                    if (p.OtherName != "")
                        fullname = string.Concat(fullname, "/", p.OtherName);
                    if (p.From != "")
                        fullname = string.Concat(fullname, "(", p.From, ")");
                    lbxInfo.Items.Add(string.Concat(p.MoralRank, "  ", fullname, "  "));
                }
            }
            else
            {
                records = records.OrderBy(m => m.ID)
                                 .ThenBy(m => m.BestowDateTime)
                                 .ToList();

                lbxInfo.Items.Clear();


                foreach (BestowRecord br in records)
                {
                    Person p = data.First(m => m.ID == br.PersonID);
                    if (p.SurnameFirst == "y")
                        fullname = string.Concat(p.Surname, p.Name);
                    else
                        fullname = string.Concat(p.Name, ".", p.Surname);
                    if (p.OtherName != "")
                        fullname = string.Concat(fullname, "/", p.OtherName);
                    if (p.From != "")
                        fullname = string.Concat(fullname, "(", p.From, ")");
                    lbxInfo.Items.Add(string.Concat(DateTime.Parse(br.BestowDateTime).ToString("MM, dd, Ar.y hh:mm:ss"), "  ", fullname, "  ", br.MoralRank));
                }
            }

            if (Index < lbxInfo.Items.Count)
                lbxInfo.SelectedIndex = Index;
        }

        private void RefreshEditArea()
        {
            pnlEditArea.Controls.Clear();
            PropertyInfo[] pis = Type.GetType(CurrentModule).GetProperties();
            for (int i = 0; i < pis.Count(); i++)
            {
                Label lblLabel = new Label();
                lblLabel.Name = string.Concat("lbl", pis[i].Name);
                lblLabel.Text = pis[i].Name;
                lblLabel.Left = 10;
                lblLabel.Top = 30 * i;
                pnlEditArea.Controls.Add(lblLabel);

                TextBox txtText = new TextBox();
                if (pis[i].Name == "LastBestowDate" || pis[i].Name == "ID" ||
                    pis[i].Name == "PersonID")
                    txtText.Enabled = false;
                if (pis[i].Name == "MoralRank" && CurrentModule == typeof(Person).ToString())
                    txtText.Enabled = false;
                txtText.Name = string.Concat("txt", pis[i].Name);
                txtText.Left = 200;
                txtText.Top = 30 * i;
                pnlEditArea.Controls.Add(txtText);
            }
        }

        private void btnSaveBestowRecords_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
                return;
            using (FileStream outputFile = File.Open(string.Concat(WebsitePath, "BestowRecords.json"), FileMode.Create))
            {
                outputFile.Position = 0;
                StreamWriter sw = new StreamWriter(outputFile);
                string json = JsonConvert.SerializeObject(records, Formatting.Indented);
                sw.Write(json);
                sw.Close();
            }
            tslMain.Text = "Bestow Records Saved.";
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (CurrentModule != typeof(Person).ToString())
                return;

            BestowRecord br = new BestowRecord(data[lbxInfo.SelectedIndex].ID);
            br.ID = records.Count;
            records.Add(br);
            btnShowBestowRecords_Click(this, e);
            lbxInfo.SelectedIndex = records.IndexOf(br);
            tslMain.Text = "Bestow Records Added.";
        }

        private void btnShowBestowRecords_Click(object sender, EventArgs e)
        {
            CurrentModule = typeof(BestowRecord).ToString();
            RefreshEditArea();
            RefreshInfoList();
            btnAddRecord.Enabled = false;
        }

        private void btnShowPersonData_Click(object sender, EventArgs e)
        {
            CurrentModule = typeof(Person).ToString();
            RefreshEditArea();
            RefreshInfoList();
            if (lbxInfo.SelectedIndex != -1)
                btnAddRecord.Enabled = true;
        }

        private void UpdatePersonData(string personID)
        {
            BestowRecord br = (from rec in records
                               where rec.PersonID == personID
                               orderby rec.BestowDateTime
                               select rec).LastOrDefault();

            Person p = data.First(m => m.ID == personID);
            if (br == null)
            {
                p.LastBestowDate = "";
                p.MoralRank = 0;
            }
            else
            {
                p.LastBestowDate = DateTime.Parse(br.BestowDateTime).ToShortDateString();
                p.MoralRank = br.MoralRank;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(WebsiteUrl);
        }

        private void btnBestowHistory_Click(object sender, EventArgs e)
        {
            //Bestow History
            using (FileStream outputFile = File.Open(string.Concat(WebsitePath, "BestowHistory.txt"), FileMode.Create))
            {
                outputFile.Position = 0;
                StreamWriter sw = new StreamWriter(outputFile);
                var query = (from r in records
                             from d in data
                             where r.PersonID == d.ID
                             orderby d.MoralRank descending, d.Gender descending, d.Fiction, d.From descending, d.Wanted descending, d.Surname descending, d.Name descending, r.BestowDateTime descending
                             select new { d.ID, d.Surname, d.Name, d.SurnameFirst, DM = d.MoralRank, RM = r.MoralRank, r.BestowDateTime }).ToList();

                int currentRank = 100;
                string currentID = "";
                sw.WriteLine("歷史評分");
                foreach (var item in query)
                {
                    if (currentRank != item.DM)
                    {
                        sw.WriteLine("");
                        sw.WriteLine(string.Concat("", item.DM));
                        currentRank = item.DM;
                    }
                    if (currentID != item.ID)
                    {
                        currentID = item.ID;
                        if (item.SurnameFirst == "y")
                            sw.WriteLine(string.Format("{0}{1}({2})", item.Surname, item.Name, DateTime.Parse(item.BestowDateTime).ToString("M, d, Ar.y")));
                        else
                            sw.WriteLine(string.Format("{0}.{1}({2})", item.Name, item.Surname, DateTime.Parse(item.BestowDateTime).ToString("M, d, Ar.y")));
                    }
                }
                sw.WriteLine("");
                sw.WriteLine(string.Concat("Created at ", DateTime.Now.AddYears(-2017).ToString("M, d, Ar.y")));
                sw.Close();
            }


            List<Article> articles;
            string QuotesOrArticles = "Quotes";
            while (true)
            {
                using (FileStream dataFile = File.Open(string.Concat(WebsitePath, QuotesOrArticles, ".json"), FileMode.Open))
                {
                    dataFile.Position = 0;
                    StreamReader sr = new StreamReader(dataFile);
                    articles = JsonConvert.DeserializeObject<List<Article>>(sr.ReadToEnd());
                    sr.Close();
                    using (FileStream outputFile = File.Open(string.Concat(WebsitePath, "Arina", QuotesOrArticles, ".txt"), FileMode.Create))
                    {
                        StreamWriter sw = new StreamWriter(outputFile);
                        foreach (Article ar in articles)
                        {
                            if (ar.Date != null)
                                sw.WriteLine(DateTime.Parse(ar.Date).ToString("M, d, Ar.y"));
                            else
                                sw.WriteLine("-");
                            sw.Write(ar.Chinese);
                            sw.WriteLine();
                            sw.Write(ar.English);
                            sw.WriteLine();
                            sw.WriteLine();
                        }
                        sw.Close();
                    }
                }
                if (QuotesOrArticles == "Quotes")
                    QuotesOrArticles = "Articles";
                else
                    break;
            }
            tslMain.Text = "Bestow History/Quotes/Articles Created.";
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            using (FileStream outputFile = File.Open(string.Concat(WebsitePath, "Backup\\Persons.json"), FileMode.Create))
            {
                outputFile.Position = 0;
                StreamWriter sw = new StreamWriter(outputFile);
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                sw.Write(json);
                sw.Close();
            }

            using (FileStream outputFile = File.Open(string.Concat(WebsitePath, "Backup\\BestowRecords.json"), FileMode.Create))
            {
                outputFile.Position = 0;
                StreamWriter sw = new StreamWriter(outputFile);
                string json = JsonConvert.SerializeObject(records, Formatting.Indented);
                sw.Write(json);
                sw.Close();
            }

            File.Copy(string.Concat(WebsitePath, "Quotes.json"), string.Concat(WebsitePath, "Backup\\Quotes.json"), true);
            File.Copy(string.Concat(WebsitePath, "Articles.json"), string.Concat(WebsitePath, "Backup\\Articles.json"), true);

            DialogResult dr = MessageBox.Show("Backup to Flash Drive(E:)?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                tslMain.Text = "Backup Completed.";
                return;
            }

            if (Directory.Exists(BackupPath))
            {
                DirectoryCopy(WebsitePath, BackupPath, false, true);
                tslMain.Text = "Backup to 2 Places Completed.";
            }
            else
            {
                MessageBox.Show("Target backup drive or directory do not exist.");
                tslMain.Text = "Backup Completed.";
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs, bool onlyFiles = false)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!onlyFiles)
            {
                Directory.CreateDirectory(destDirName);
            }
            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, true);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnLoad_Click(this, e);
        }

        private void btnRefreshNo_Click(object sender, EventArgs e)
        {
            List<Article> articles;
            string QuotesOrArticles = "Quotes";
            while (true)
            {
                using (FileStream dataFile = File.Open(string.Concat(WebsitePath, QuotesOrArticles, ".json"), FileMode.Open))
                {
                    StreamReader sr = new StreamReader(dataFile);
                    articles = JsonConvert.DeserializeObject<List<Article>>(sr.ReadToEnd());
                    sr.Close();
                }
                for (int i = 0; i < articles.Count; i++)
                    articles[i].No = i;
                using (FileStream dataFile = File.Open(string.Concat(WebsitePath, QuotesOrArticles, ".json"), FileMode.Create))
                { 
                    StreamWriter sw = new StreamWriter(dataFile);
                    sw.Write(JsonConvert.SerializeObject(articles, Formatting.Indented));
                    sw.Close();
                }
                if (QuotesOrArticles == "Quotes")
                    QuotesOrArticles = "Articles";
                else
                    break;
            }
            tslMain.Text = "Quotes/Articles Refreshed.";
        }
    }
}
