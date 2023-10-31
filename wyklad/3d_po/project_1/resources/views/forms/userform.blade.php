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
<form action="AddUserController" method="get">
  <input type="text" name="firstName" placeholder="Podaj imię"><br><br>
  <input type="text" name="lastName" placeholder="Podaj nazwisko"><br><br>
  <input type="date" name="birthday"> data urodzenia<br><br>
  <input type="email" name="email" placeholder="Podaj email"><br><br>
  <input type="password" name="pass" placeholder="Podaj hasło"><br><br>
  <input type="submit" value="Dodaj użytkownika">
</form>
</body>
</html>
