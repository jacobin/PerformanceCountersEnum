//  ---------------------------------------------------------------------------
//  Author:     Marc Ochsenmeier
//  Email:      info@winssential.net
//  Web:        www.winssential.net
//  Project:    "Performance Counters Enumerator" for www.codeproject.com
//
//  Date        11.Feb.2010
//  ---------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//  Integrate the Performance counters class.
using System.Diagnostics;

//  Use XML
using System.Xml;

namespace Performance_Counters_Enumerator
{
    public partial class Form1 : Form
    {
        //  Show Hide Counters at the UI.
        bool m_bShowCounters = false;
        CPerformanceCountersManager performanceCountersMgr = null;
        int initialWidth = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            //  Retrieving PCs might take a while...
            Cursor.Current = Cursors.WaitCursor;
            btnUpdate.Enabled = false;
            btnExport.Enabled = false;
            checkBoxCategoryDescription.Enabled = false;
            btnShowCounters.Enabled = false;

            //  Cleanup the Views containing the Peformance Counters.
            CleanViewCategories();
            CleanViewCounters();

            //  Get the Categories of Performance Counters
            performanceCountersMgr.GetPerformanceCountersCategories(txtMachine.Text.ToString());
            PerformanceCounterCategory[] categories = performanceCountersMgr.Categories;
            for (int i = 0; i < categories.Length; i++)
            {
                //  Show these at the UI
                UpdateViewCategories(categories[i]);
            }

            //  Show number of PCounters found.
            txtNumberOfCategoriesFound.Text = categories.Length.ToString();

            //  Finished.
            Cursor.Current = Cursors.Arrow;
            btnUpdate.Enabled = true;
            if (categories.Length > 0)
            {
                btnExport.Enabled = true;
                checkBoxCategoryDescription.Enabled = true;
                btnShowCounters.Enabled = true;
            }
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            //  Export button disabled.
            btnExport.Enabled = false;
            checkBoxCategoryDescription.Enabled = false;
            btnShowCounters.Enabled = false;
            txtNumberOfCategoriesFound.Text = "";

            //  Instantiate our Performance Counters Manager
            performanceCountersMgr = new CPerformanceCountersManager();

            //  Hide Counters UI
            this.Width = this.Width - groupCategories.DisplayRectangle.Right - 12;
            initialWidth = this.Width;

            //  Retrieve the machine's name.
            txtMachine.Text = Environment.MachineName;

            //  Cleanup the View containing the Peformance Counters.
            CleanViewCategories();
            CleanViewCounters();
        }
       
        /// <summary>
        /// Populate the Peformance Counters Categories
        /// </summary>
        /// <param name="collector"></param>
        void UpdateViewCategories(PerformanceCounterCategory category)
        {
            ListViewItem lvItem = new ListViewItem();
            lvItem.Text = category.CategoryName;
            lvItem.ImageIndex = 0;
            ListViewItem.ListViewSubItem lvSubItem = new ListViewItem.ListViewSubItem();
            lvSubItem.Text = category.CategoryName;
            lvItem.SubItems.Add(lvSubItem);
            listViewCategories.Items.Add(lvItem);

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filename = dlg.FileName;
                XmlTextWriter xml = new XmlTextWriter(filename, Encoding.UTF8);
                xml.WriteStartDocument(true);
                xml.WriteStartElement("Categories");

                PerformanceCounterCategory[] category = performanceCountersMgr.Categories;

                for (int i = 0; i < category.Length; i++)
                {
                    xml.WriteStartElement("Categorie");
                    xml.WriteStartAttribute("Name");
                    xml.WriteString(category[i].CategoryName);

                    if (checkBoxCategoryDescription.Checked)
                    {
                        xml.WriteStartAttribute("Description");
                        xml.WriteString(category[i].CategoryHelp);
                    }
                    xml.WriteEndAttribute();
                    xml.WriteEndElement(); 
                }
                
                //  End of Categories Element
                xml.WriteEndElement();  
                xml.Close();
            }

        }

        private void btnShowCounters_Click(object sender, EventArgs e)
        {
            m_bShowCounters = !m_bShowCounters;
            this.Width = m_bShowCounters ? (initialWidth + groupBoxCounters.DisplayRectangle.Width +16) : initialWidth;
            btnShowCounters.Text = !m_bShowCounters ? "Counters >>":"Counters <<";
        }

        void CleanViewCategories()
        {
            listViewCategories.Clear();
            listViewCategories.FullRowSelect = true;
            listViewCategories.HideSelection = false;
            //listViewCategories.Sorting = SortOrder.Ascending;

            ColumnHeader nameHeader = new ColumnHeader();
            nameHeader.Width = listViewCategories.Width - 4;
            nameHeader.Text = "Name";
            listViewCategories.Columns.Add(nameHeader);
            txtNumberOfCategoriesFound.Text = "";
        }
        
        private void CleanViewCounters()
        {
            listViewCounters.Clear();
            listViewCounters.FullRowSelect = true;
            listViewCounters.HideSelection = false;
            listViewCounters.Sorting = SortOrder.Ascending;
            
            ColumnHeader nameHeader = new ColumnHeader();
            nameHeader.Width = listViewCounters.Width - 4;
            nameHeader.Text = "Name";
            listViewCounters.Columns.Add(nameHeader);

            textBoxCounterDescription.Text = "";
        }
        
        private void OnSelectedCategory(object sender, EventArgs e)
        {
            //  Clean Counters View from previous usage.
            CleanViewCounters();

            //  Wait Cursor
            Cursor.Current = Cursors.WaitCursor;

            //  Collect Counters for the selected Category
            ListView.SelectedListViewItemCollection sel = listViewCategories.SelectedItems;
            if(sel != null && sel.Count > 0)
            {
                //  Show Description of the selected Category
                PerformanceCounterCategory[] category = performanceCountersMgr.Categories;
                textBoxCategoryDescription.Text = category[sel[0].Index].CategoryHelp;

                //  Acquire the Counters of the selected Category
                //Console.Write("Selected Category: {0}" , category[sel[0].Index].CategoryName);
                PerformanceCounter[] counters = performanceCountersMgr.GetPerformanceCounters(category[sel[0].Index]);
                if (counters != null)
                {
                    for (int i = 0; i < counters.Length; i++)
                    {
                        PerformanceCounter counter = counters[i];
                        UpdateViewCounters(counter);
                    }
                    listViewCounters.Items[0].Selected = true;
                }
                //listViewCategories.Items[0].Selected = true;
            }

            //  Restore
            Cursor.Current = Cursors.Arrow;
        }
        
        /// <summary>
        /// Populate the Peformance Counters for the selected Category
        /// </summary>
        /// <param name="collector"></param>
        void UpdateViewCounters(PerformanceCounter counter)
        {
            ListViewItem lvItem = new ListViewItem();
            lvItem.Text = counter.CounterName;
            lvItem.ImageIndex = 0;
            ListViewItem.ListViewSubItem lvSubItem = new ListViewItem.ListViewSubItem();
            lvSubItem.Text = counter.CategoryName;
            lvItem.SubItems.Add(lvSubItem);
            listViewCounters.Items.Add(lvItem);
        }

        private void OnCounterSelected(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection sel = listViewCounters.SelectedItems;
            if (sel != null && sel.Count > 0)
            {
                //  Show Description of the selected Category
                PerformanceCounter[] counter = performanceCountersMgr.Counters;
                textBoxCounterDescription.Text = counter[sel[0].Index].CounterHelp;
            }

        }
    }
}
