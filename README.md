# IBAN Helper ![.NET 6](https://github.com/hendrikdevestel/IbanHelper/workflows/.NET%206/badge.svg)

IbanHelper helps you working with IBAN bank account numbers. Validating the numbers and know the bank name. All countries are included in the validation. At this moment there are only some countries added for bank names. These countries are Belgium, The Netherlands and France.

Nuget Package: https://www.nuget.org/packages/IbanHelper

## Usage

#### IbanValidator
```csharp
var card = IbanValidator.Validate("FR 76 30056 00927 12345678901 82");
var isValid = card.IsValid;
var bankName = card.BankName;
// = CreditCardType.Unknown
```
