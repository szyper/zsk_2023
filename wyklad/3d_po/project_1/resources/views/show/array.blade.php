<!doctype html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
  <h3>Użytkownicy</h3>
  {{ print_r($users) }}
  <hr>
  Imię i nazwisko: {{ $users['firstName'] }} {{ $users['lastName'] }}<br>

  {{ print_r($users['colors']) }}<br><br>

  Ulubiony kolor: {{ $users['colors']['0'] }}<br><br>


  Ulubione kolory:
  <ol>
    @foreach($users['colors'] as $color)
      <li>{{ $color }}</li>
    @endforeach
  </ol>

Klucz: {{ $users['key'] }}

</body>
</html>
