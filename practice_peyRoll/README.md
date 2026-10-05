##  C# Gross Pay Calculator – Script

Hello everyone.

Today, I am going to explain my **C# Windows Forms project**, which is called **Employee Gross Pay Calculator**.

This program is used to calculate an employee's gross pay based on two inputs: **hours worked** and **pay rate**.

The formula is:

**Gross Pay = Hours Worked × Pay Rate**

First, I created three variables:

```csharp
double hour_worked, payrate, grosspay;
```

`hour_worked` stores the number of hours the employee worked.

`payrate` stores how much the employee is paid per hour.

And `grosspay` stores the final calculated amount.

Next, I used `double.TryParse()` to validate the user's input.

```csharp
if (double.TryParse(textHourworked.Text, out validation) &&
    double.TryParse(textPeyrate.Text, out validation))
```

The purpose of `TryParse()` is to check whether the user entered a valid number.

For example, if the user enters **40** and **10**, the input is valid.

But if the user enters letters such as **abc**, the program will show an error message instead of causing a conversion error.

After validating the input, I assign the values to my variables:

```csharp
hour_worked = double.Parse(textHourworked.Text);
payrate = double.Parse(textPeyrate.Text);
```

Then, I check whether both values are greater than zero:

```csharp
if (hour_worked > 0 && payrate > 0)
```

This prevents the user from entering zero or negative values.

If the values are valid, the program calculates the gross pay:

```csharp
grosspay = hour_worked * payrate;
```

For example, if the employee worked **40 hours** and the pay rate is **10 dollars**, the calculation will be:

```text
40 × 10 = 400
```

Then I display the result in the label:

```csharp
lblcalculate.Text = grosspay.ToString("c");
```

The `"c"` means **currency format**, so the result will be displayed as money.

**Clear button**.
textHourworked.Clear();
textPeyrate.Clear();
lblcalculate.Text = "";


When the user clicks Clear, the input fields and the result are removed.

 **Close button**:
Application.Exit();
This closes the application.

### Conclusion

In this project, I learned how to use variables, input validation, TryParse, if statements, calculations, event handling, Windows Forms controls, and currency formatting in C# .

# END
