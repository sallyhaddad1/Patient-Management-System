# Patient Management System

This project is a Windows Forms application designed to handle and display patient information, including patient details, insurance degree, medical procedures, and result dates. It features an interactive form for entering and managing patient records, including gender, insurance degree, and medical procedure type.

## Features

- **Patient Information Input**: Allows the user to input a patient's name, ID, gender, degree of insurance, and the type of medical procedure.
- **Medical Procedure Handling**: The application supports different medical procedures, including:
  - CPR
  - ECG (displays result date 2 days after procedure date)
  - Ultrasound (displays result date 3 days after procedure date)
- **Insurance Calculation**: The application calculates the insurance coverage based on the degree of insurance (First, Second, or Third).
- **Clear and Reset**: Reset the form to its initial state for entering a new patient's details.
- **Exit Functionality**: A button to close the application.
- **Result Display**: After filling out the form and selecting a medical procedure, the results are displayed in a textbox along with the calculated insurance percentage.
  
## How to Use

1. **Fill in Patient Information**:
   - Input the patient's name and ID into the provided textboxes.
   - Select the patient's gender by choosing either Male or Female.
   - Select the degree of insurance (First, Second, or Third).

2. **Select Medical Procedure**:
   - Choose the type of medical procedure: CPR, ECG, or Ultrasound.
   - For ECG and Ultrasound, the system will automatically calculate the result date based on the procedure date.

3. **View Results**:
   - After entering all the necessary details, click the `Add` button to display the patient’s summary information in the `textBox3` field, including the percentage of the cost covered by insurance based on the degree selected.

4. **Reset the Form**:
   - To reset all fields for a new entry, click the `Clear` button. This will clear all inputs, reset date fields, and uncheck all selections.

5. **Exit the Application**:
   - Click the `Exit` button to close the application.

## Insurance Calculation

- **First Degree**: Covers 15% of the medical procedure cost.
- **Second Degree**: Covers 10% of the medical procedure cost.
- **Third Degree**: Covers 5% of the medical procedure cost.

## Additional Features

- **Multiline and Read-Only TextBox**: The display textbox can be toggled between multiline and single-line, and it can also be set to read-only mode, depending on user preference.
  
## Controls

- **Patient Name**: Textbox for entering the patient's name.
- **Patient ID**: Textbox for entering the patient's ID.
- **Gender**: Radio buttons for selecting the patient's gender (Male or Female).
- **Insurance Degree**: Radio buttons for selecting the patient's degree of insurance (First, Second, or Third).
- **Medical Procedure**: Radio buttons for selecting the medical procedure (CPR, ECG, or Ultrasound).
- **Date Picker**: A DateTimePicker to select the date of the medical procedure.
- **Display Box**: A textbox that shows the patient's full information after clicking the "Add" button.
  
## Error Handling

- Ensures all fields are filled before proceeding to calculate and display the result.
- The form resets with appropriate checks for input validation.
  

