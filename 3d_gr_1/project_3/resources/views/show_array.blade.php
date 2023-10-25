<!doctype html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Użytkownik</title>
</head>
<body>
<h3>Dane użytkownika</h3>
{{-- {{ print_r($data) }} --}}
{{--{{ print_r($data['hobby']) }}--}}
{{ $data['hobby'][0] }}

Imię i nazwisko: {{ $data['firstName'] }} {{ $data['lastName'] }}<br>
Miasto: {{ $data['city'] }}<br>
Hobby:
<ul>
    @foreach($data['hobby'] as $hobby)
        <li>{{ $hobby }}</li>
    @endforeach
</ul>
</body>
</html>
