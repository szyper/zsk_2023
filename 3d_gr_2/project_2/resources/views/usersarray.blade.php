<!doctype html>
<html lang="pl">
<head>
  <meta charset="UTF-8">
  <meta name="viewport"
        content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
  <meta http-equiv="X-UA-Compatible" content="ie=edge">
  <title>Użytkownicy</title>
</head>
<body>
  <h3>Użytkownicy</h3>
{{--  {{ print_r($users) }}--}}
Imię i nazwisko: {{ $firstName }} {{ $lastName }}<br>
Miasto: {{ $city }}<br>

Hobby: <ul>@foreach($hobby as $x)
              <li>{{ $x }}</li>
           @endforeach
       </ul>
</body>
</html>
