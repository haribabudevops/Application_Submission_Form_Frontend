# ApplicationSubmissionForm

This is a Windows desktop application created with Visual Basic to manage form submissions. The application allows users to create new submissions and view existing submissions.

## Features
- **View Submissions**: Navigate through submitted forms.
- **Create New Submissions**: Fill out and submit a new form with a stopwatch timer.
- **Keyboard Shortcuts**: Use keyboard shortcuts to toggle the stopwatch and submit the form.

## Prerequisites
- Visual Studio
- .NET Framework
- Node.js (for the backend server)

## How to Run

### Frontend (Windows Desktop Application)
1. **Clone the repository**:
    ```sh
    https://github.com/haribabudevops/Application_Submission_Form_Frontend.git
    ```
2. **Open the solution**:
    - Open Visual Studio.
    - Click on `File > Open > Project/Solution`.
    - Navigate to the cloned repository and open the solution file.
3. **Build and run the project**:
    - Click on `Build > Build Solution`.
    - Click on `Debug > Start Debugging` or press `F5`.

## Project Structure
ApplicationSubmissionForm/
├── My Project/
│ ├── Application.Designer.vb
│ ├── Application.myapp
├── ApplicationEvents.vb
├── ApplicationSubmissionForm.vbproj
├── CreateNewSubmissions.Designer.vb
├── CreateNewSubmissions.resx
├── CreateNewSubmissions.vb
├── Form1.Designer.vb
├── Form1.resx
├── Form1.vb
├── ViewSubmissions.Designer.vb
├── ViewSubmissions.resx
├── ViewSubmissions.vb
├── .gitattributes
├── .gitignore
├── ApplicationSubmissionForm.sln
└── README.md

## File Descriptions
- **CreateNewSubmissions.vb**: Form to create new submissions with a stopwatch.
- **ViewSubmissions.vb**: Form to view existing submissions with navigation buttons.
- **MainForm.vb**: Main form with buttons to navigate to Create New Submissions and View Submissions forms.
- **SubmissionInfo.vb**: Class to hold submission information.

## Keyboard Shortcuts
- **Ctrl + V**: View Submissions.
- **Ctrl + P**: Previous in View Submissions Form.
- **Ctrl + N**: Next in View Submissions Form.
- **Ctrl + N**: Create New Submission.
- **Ctrl + T**: Toggle the stopwatch in Create New Submissions Form.
- **Ctrl + S**: Submit the form in Create New Submissions Form.

## License
See the [LICENSE](LICENSE.md) file for license rights and limitations (MIT).
