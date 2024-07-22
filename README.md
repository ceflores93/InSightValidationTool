# WebAPISampleApp
This is a simple Windows Forms HMI application that uses the In-Sight Web API.
It includes a project to build a base assembly for accessing the Web API, Cognex.InSight.Web.
It also includes a project that holds the Windows Form Controls for visualization, Cognex.InSight.Web.Controls.

## Project
This Visual Studio 2019 project uses .Net 4.8.

## Application 
The MainForm in the application includes:
 * Connecting to an IP address with HMI port using a designated username and password
 * Menu that includes manual trigger, online/offline, information about the camera, etc
 * A CvsDisplay control to display the image and graphics
 * A CvsSpreadsheet control to display the spreadsheet
 * A CvsCustomView control to display the custom view
 * A CvsFilmstrip control to display the results queue filmstrip

## Cognex.InSight.Web Project
This project provides the core classes to establish a CogSocket connection to the In-Sight camera.

Includes:
* CvsInSight.cs class and the supporting SimpleCogSocket classes

## Cognex.InSight.Web.Controls Project
This project provides the controls and dependencies that rely on Windows Forms.

Includes:
* CvsDisplay.cs UserControl that uses PictureBox to display the image from the results and overwrites graphics
* CvsSpreadsheet.cs UserControl that uses a DataGridView to display a spreadsheet for the cell results
* CvsCustomView.cs UserControl that uses the CvsSpreadsheet to display a custom view
* CvsFilmstrip.cs UserControl to display the results queue filmstrip

## Support for Dialogs, Wizards, and Bitmaps
Because the new In-Sight sensors (2800/3800 and beyond) do not support the Wizard and Dialog cells, support for
HMI defined cells is added. The "Jobs" directory includes a sample job, ExampleHmiSpreadsheetCells.jobx, and 
json file, ExampleHmiSpreadsheetCells.json. This json file contains definitions for cells that will overwrite or 
replace any cells from the sensor when they are displayed in the sample application. This json file may be loaded
in the sample application after the correct job has been loaded in the sensor.

The following cell types are supported:
* DialogCell - Display a "Dialog" button at the designated location. This button will display the designated dialog.
Example:
  {
     "$type": "DialogCell",
     "location": "A3",
     "label": "Dialog1",
     "title": "Dialog 1",
     "range": "A400:E405"
   }

* WizardCell - Display a "Wizard" button at the designated location. This button will cycle through the designated
dialogs.
Example:
    {
      "$type": "WizardCell",
      "location": "A2",
      "label": "MyWizard",
      "dialogs": [ "A3", "A4" ]
    }

* BitmapCell = Display the designated bitmap in the cell. The image will be loaded from the same directory as the
json file.
Example:
    {
      "$type": "BitmapCell",
      "location": "A1",
      "file": "Nyan_cat_125px_frame.png"
    }
