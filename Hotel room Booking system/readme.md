Hotel Room Booking Calculator

## Project Overview

The Hotel Room Booking Calculator is a C# Windows Forms application developed using Visual Studio. It helps users calculate hotel room booking costs based on guest information, room type, number of nights, and additional services.

## Project Objectives

* Collect guest information.
* Validate user inputs using TryParse.
* Select room types and determine room rates using a switch statement.
* Approve or reject bookings based on room capacity.
* Calculate discounts, breakfast costs, and service surcharges.
* Display booking details and the final cost in a ListBox.


## Room Types and Rates

Room Type	Rate Per Night	Maximum Guests
Standard	$50	2
Normal (Deluxe)	$80	4
Hight (Suite)	$130	6

## Booking Rules

* Guest name must not be empty.
* Guest age must be between 18 and 90.
* Number of nights must be between 1 and 30.
* Number of guests must be between 1 and 6.
* Bookings exceeding room capacity are rejected.

## Cost Calculation Rules

* 1–4 nights: No discount.
* 5–9 nights: 5% discount.
* 10 or more nights: 12% discount.
* Breakfast: $10 per guest per night.
* More than 4 guests: 5% service surcharge.
* Guests aged 60 or above: Additional 5% senior discount.

## Application Features

* Calculate: Validates inputs and calculates the total booking cost.
* Clear: Clears all fields and resets the options.
* Exit: Closes the application.
* ListBox: Displays booking details, discounts, additional charges, and the final cost.



## Conclusion

This project demonstrates the use of C# programming concepts, including variables, data validation, conditional statements, switch statements, Boolean flags, event handling, and arithmetic calculations in a Windows Forms application.

## END