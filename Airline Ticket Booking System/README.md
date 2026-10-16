# Airline Ticket Booking Calculator

## Project Description
The Airline Ticket Booking Calculator is a C# Windows Forms application that calculates the total cost of airline tickets based on passenger information, travel class, number of tickets, baggage weight, discounts, and insurance.

The application validates user inputs and displays the booking details and final cost in a ListBox.

## Features
- Enter passenger name and age.
- Select travel class:
  - First Class — $400 per ticket
  - Normal Class — $150 per ticket
  - Business Class — $650 per ticket
- Enter the number of tickets (1–5).
- Enter baggage weight (up to 50 kg).
- Apply discounts based on the number of tickets.
- Apply child and senior citizen discounts.
- Add optional travel insurance.
- Display booking details and final cost in a ListBox.
- Clear all input fields.
- Exit the application.

## Business Rules

### 1. Input Validation
- Passenger age must be between 1 and 100.
- Number of tickets must be between 1 and 5.
- Baggage weight must be greater than 0 kg and not exceed 50 kg.
- Numeric fields must contain valid numeric values.
- A travel class must be selected.
- Passengers below 12 years old cannot book First Class.

### 2. Ticket Prices
| Travel Class | Price per Ticket |
|---|---:|
| First Class | $400 |
| Normal Class | $150 |
| Business Class | $650 |

### 3. Discounts
- 3–4 tickets: 5% discount on the basic ticket cost.
- 5 tickets: 10% discount on the basic ticket cost.
- Children below 12 years: 20% discount on the subtotal.
- Senior passengers aged 60 and above: 10% discount on the subtotal.

### 4. Insurance
- Optional insurance costs $25 per ticket.
- Insurance is added to the final cost when selected.

## Calculation Formulas

**Basic Ticket Cost**

Basic Ticket Cost = Ticket Price × Number of Tickets

**Ticket Discount**

The discount depends on the number of tickets booked.

**Subtotal**

Subtotal = Basic Ticket Cost − Ticket Discount

**Final Cost**

Final Cost = Subtotal − Child Discount − Senior Discount + Insurance Cost

## Technologies Used
- C#
- .NET Windows Forms
- Visual Studio
- ListBox
- TextBox
- RadioButton
- CheckBox
- MessageBox

## How to Run the Project
1. Open the project in Visual Studio.
2. Build the solution.
3. Run the application.
4. Enter the passenger details.
5. Select a travel class.
6. Choose whether to include insurance.
7. Click the booking/calculation button.
8. View the booking summary and final cost in the ListBox.
9. Use the Clear button to reset the form.
10. Use the Exit button to close the application.

## Project Controls
- `txtname` — Passenger name
- `txtAge` — Passenger age
- `txtnumberoftickets` — Number of tickets
- `txtbaggageweigth` — Baggage weight
- `rbtnfirst` — First Class
- `rbtnnormal` — Normal Class
- `rbtnbusiness` — Business Class
- `checkboxinsurance` — Optional insurance
- `listBox1` — Booking summary
- `btnclear` — Clear inputs
- `button3` — Exit application

## END
