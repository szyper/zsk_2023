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
@if($errors->any())
    <ul>
        @foreach($errors->all() as $error)
            <li>{{ $error }}</li>
        @endforeach
    </ul>
@endif
<form action="UserFormController" method="get">
    <input type="text" name="firstName" placeholder="Podaj imię" autofocus value="{{old('firstName')}}">
    @error('firstName')
        {{ $message }}
    @enderror<br><br>
    <input type="text" name="lastName" placeholder="Podaj nazwisko" value="{{old('lastName')}}">
    @error('lastName')
    {{ $message }}
    @enderror<br><br>
    <input type="email" name="mail" placeholder="Podaj adres @" value="{{old('mail')}}">
    @error('mail')
    {{ $message }}
    @enderror<br><br>
    <input type="submit" value="Zatwierdź dane">
</form>
</body>
</html>
