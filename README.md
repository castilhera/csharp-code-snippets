# C# Code Snippets

A bunch of random C# code snippets that might help.

## Extensions

### Date Extensions

<dl>
  <dt>IsWeekend</dt>
  <dd>Check if DayOfWeek is Saturday or Sunday. (Note: This does not apply to all countries and cultures. I found it useful for Brazil.)</dd>
  <dt>ToFirstDayOfMonth</dt>
  <dd>Returns the first day of the month for the specified DateOnly/DateTime/DateTimeOffset.</dd>
  <dt>ToLastDayOfMonth</dt>
  <dd>Returns the last day of the month for the specified DateOnly/DateTime/DateTimeOffset.</dd>
  <dt>GetIso8601WeekNumber</dt>
  <dd>Returns the week of the year, according to ISO-8601, for the specified DateTime.</dd>
</dl>

### Stream Extensions

<dl>
  <dt>ReadLinesAsync</dt>
  <dd>Returns an iterator to read a stream line by line</dd>
</dl>

### String Extensions

<dl>
  <dt>Reverse</dt>
  <dd>Reverses a given string. e.g. ABCD => DCBA</dd>
  <dt>ToSnakeCase</dt>
  <dd>Convert string to snake_case format. e.g. CodeSnippets => code_snippets</dd>
</dl>

## Helpers

### Validation Helpers

<dl>
  <dt>IsValidCnpj</dt>
  <dd>Check if the given string is a valid CNPJ.</dd>

  <dt>IsValidCpf</dt>
  <dd>Check if the given string is a valid CPF.</dd>
</dl>
