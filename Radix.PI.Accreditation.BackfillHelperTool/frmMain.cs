using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSIsoft.AF;
using OSIsoft.AF.Time;
using OSIsoft.AF.Asset;
using OSIsoft.AF.Analysis;
using OSIsoft.AF.Data;


namespace Radix.PI.Accreditation.BackfillHelperTool
{
    public partial class frmMain : Form
    {

        public AFElement selectedElement { get; set; }
        public AFAnalysisService.CalculationMode backfillCalcMode { get; set; }
        public List<AFAnalysis> selectedAnalyses { get; set; }

        public frmMain()
        {
            InitializeComponent();

            cbBackfillMode.Items.Add("Only Fill in Gaps");
            cbBackfillMode.Items.Add("Delete All Data and Recalculate");
            cbBackfillMode.SelectedIndex = 0;
            backfillCalcMode = AFAnalysisService.CalculationMode.FillDataGaps;
            chbCalcDependencies.Enabled = false;
        }

        private void piSystemPicker_ConnectionChange(object sender, OSIsoft.AF.UI.SelectionChangeEventArgs e)
        {
            afDatabasePicker.PISystem = piSystemPicker.PISystem;
        }

        private void afDatabasePicker_SelectionChange(object sender, OSIsoft.AF.UI.SelectionChangeEventArgs e)
        {
            afTreeView1.AFRoot = afDatabasePicker.AFDatabase.Elements;
        }

        private void afTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedElement = afTreeView1.AFSelection as AFElement;
            lbSelectedAnalysis.Items.Clear();

            if (selectedElement != null)
            {
                getSelectedAnalysesBySelectedElement();
                filterSelectedAnalysesByInputedName();
                printSelectedAnalysesInDisplay();
            }
        }

        private void printSelectedAnalysesInDisplay()
        {
            lbSelectedAnalysis.Items.Clear();
            lbSelectedAnalysis.Items.AddRange(selectedAnalyses.ToArray<AFAnalysis>());
        }

        private void getSelectedAnalysesBySelectedElement()
        {
            selectedAnalyses = selectedElement.Analyses.ToList<AFAnalysis>();
        }

        private void cbBackfillMode_SelectedIndexChanged(object sender, EventArgs e)
        {

            setBackfillSelectedMode();
        }

        private void setBackfillSelectedMode()
        {
            string selectedMode = cbBackfillMode.SelectedItem as string;

            if (!String.IsNullOrEmpty(selectedMode))
            {
                switch (selectedMode)
                {
                    case "Only Fill in Gaps":
                        backfillCalcMode = AFAnalysisService.CalculationMode.FillDataGaps;
                        chbCalcDependencies.Enabled = false;
                        break;
                    case "Delete All Data and Recalculate":
                        backfillCalcMode = AFAnalysisService.CalculationMode.DeleteExistingData;
                        chbCalcDependencies.Enabled = true;
                        checkCalcDependenciesOptionEnabled();
                        break;
                    default:
                        break;
                }
            }
        }

        private void chbCalcDependencies_CheckedChanged(object sender, EventArgs e)
        {
            checkCalcDependenciesOptionEnabled();
        }

        private void checkCalcDependenciesOptionEnabled()
        {
            if (chbCalcDependencies.Checked)
            {
                if (backfillCalcMode != AFAnalysisService.CalculationMode.FillDataGaps)
                {
                    backfillCalcMode = AFAnalysisService.CalculationMode.DeleteExistingDataCalculateDependents;
                }
            }
            else
            {
                if (backfillCalcMode != AFAnalysisService.CalculationMode.FillDataGaps)
                {
                    backfillCalcMode = AFAnalysisService.CalculationMode.DeleteExistingData;
                }
            }
        }

        private void tbNameFilter_TextChanged(object sender, EventArgs e)
        {

            filterSelectedAnalysesByInputedName();
            printSelectedAnalysesInDisplay();
        }

        private void filterSelectedAnalysesByInputedName()
        {
            selectedAnalyses = selectedElement.Analyses.Where<AFAnalysis>(a =>
                a.Name.ToLower().Contains(tbNameFilter.Text.ToLower())).ToList<AFAnalysis>();
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            AFAnalysisService service = afDatabasePicker.PISystem.AnalysisService;
            AFTime startTime = new AFTime(tbStartTime.Text);
            AFTime endTime = new AFTime(tbEndTime.Text);
            AFTimeRange timeRange = new AFTimeRange(startTime,endTime);

            queueBackfill(service, timeRange);
        }

        private void queueBackfill(AFAnalysisService service, AFTimeRange timeRange)
        {
            string outNotQueueReason;
            bool canQueue = service.CanQueueCalculation(out outNotQueueReason);

            if (canQueue)
            {
                var queueResponse = service
                    .QueueCalculation(selectedAnalyses, timeRange, backfillCalcMode);
                string message;
                message = String.Format("{0} - {1} {2} {3}"
                    , DateTime.Now.ToString()
                    , selectedAnalyses.Count.ToString()
                    , "Analyses Backfill queued successfully. Request ID:"
                    , queueResponse.ToString());
                lbLog.Items.Add(message);
            }
            else
            {
                string message;
                message = String.Format("{0} - {1}", DateTime.Now.ToString(), "AF Analysis Service is not available for queuing...");
                lbLog.Items.Add(message);
                message = String.Format("{0} - Reason: {1}", DateTime.Now.ToString(), outNotQueueReason);
                lbLog.Items.Add(message);
            }
        }

    }
}
