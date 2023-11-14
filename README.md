# Sales Receipt Generator

This is a simple C# console application that allows you to create a sales receipt for a customer. You can input customer information such as first name, last name, phone number, email address, and address. Additionally, you can input the prices of up to 5 items, and the application will calculate the total price, sales tax, and display the receipt with all the details.

## Usage

1. Run the application by executing the `SalesReceipt.cs` file.
2. Follow the prompts to enter the customer's information and the prices of up to 5 items.
3. The application will then calculate and display the total price, sales tax, and generate a sales receipt with customer details.

## Code Overview

The code consists of a single C# class named `SalesReceipt`, which contains the following key elements:

- Variables to store customer information such as first name, last name, phone number, email address, and address.

- A loop that allows you to input the prices of up to 5 items.

- Calculation of the total price and sales tax (4% of the total price).

- Display of the total price, sales tax, and the total price with tax.

- Output of a sales receipt with customer details and a breakdown of the costs.

## Example

Here's an example of what the generated sales receipt might look like:

```
Create a sales receipt for a customer
Enter the first name of the customer: John
Enter the last name of the customer: Doe
Enter the customer phone number: 123-456-7890
Enter the email address for the customer: johndoe@example.com
Enter full customer address: 123 Main Street

Enter the sales price for item 1: 10
Enter the sales price for item 2: 15
Enter the sales price for item 3: 20
Enter the sales price for item 4: 25
Enter the sales price for item 5: 30

Total price for 5 purchased items is: $100
Total price for all 5 items including sales tax is: $104

Customer Name        Customer Phone Number    Customer Email    Customer Address
John Doe             123-456-7890            johndoe@example.com    123 Main Street
Total                Tax                      Total with tax
$100                 $4                       $104
```

Feel free to modify and extend this code to suit your specific requirements. Enjoy using this simple sales receipt generator!
