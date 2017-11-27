---
Title: Address Examples
Description: Examples of using Address related methods
---

Examples of available methods and a possible output from a call.
See the [API documentation](../../api/Faker/Address) for the syntax of the methods.

**NOTES:**
By adding `using Faker;`, all `Faker.` prefixes in the examples can be removed.

## Building Number
The method BuildingNumber will output a randomly generated
number that should be a valid building number in the currently used locale.
```
Faker.Address.BuildingNumber();
```
**OUTPUTS:** "65337"

## City
The method City will output a randomly generated
city within a limited list of items from the currently used locale.
```
Faker.Address.City();
```
**OUTPUTS:** "East Omafurt"

## City Prefix
The method CityPrefix will output a randomly generated city prefix.
```
Faker.Address.CityPrefix()
```
**OUTPUTS:** "Port"

## City Suffix
The method CitySuffix will output a randomly generated city suffix.
```
Faker.Address.CitySuffix()
```
**OUTPUTS:** "furt"

## Country
The method Country will output a randomly selected Country from the included list
for the used locale.
```
Faker.Address.Country()
```
**OUTPUTS:** "Vietnam"

## Country Code
The method CountryCode will output a randomly selected Country Code from the included list
for the used locale.
```
Faker.Address.CountryCode();
```
**OUTPUTS:** "MG"

## Default Country
This method will output the current country for the used locale, nothing will be randomly generated
int this case.
```
Faker.Address.DefaultCountry();
```
**OUTPUTS:** "United States" *(When the culture `en-US` is used)*

## Latitude
Will generate a random valid latitude position.
```
Faker.Address.Latitude();
```
**OUTPUTS:** 84.308

## Longitude
Will generate a random valid longitude position.
```
Faker.Address.Longitude()
```
**OUTPUTS:** 11.797

## Secondary Address
Will generate a random secondary address from a static list using the currently used locale.
```
Faker.Address.SecondaryAddress();
```
**OUTPUTS:** "Apt 409"

## State
Will generate a random state if the current culture support states,
otherwise it will output a Random Country instead.
```
Faker.Address.State();
```
**OUTPUTS:** "New Mexico"

## State Abbreviation
Will generate a random state abbreviation if the current culture suppport states,
otherwise it will output a Random Country Code instead.
```
Faker.Address.StateAbbreviation();
```
**OUTPUTS:** "AL"

::: { .alert .alert-info }
**TODO: Add rest of methods**
:::