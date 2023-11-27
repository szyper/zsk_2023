<!doctype html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Dodanie użytkownika</title>
</head>
<body>
    <h4>Dodawanie użytkownika</h4>
    <form action="" method="post">
        <input type="text" name="name" value="{{old('name')}}" placeholder="Podaj nazwę użytkownika" autofocus><br><br>
        <input type="email" name="email" value="{{old('email')}}" placeholder="Podaj email"><br><br>
        <input type="email" name="reemail" value="{{old('reemail')}}" placeholder="Powtórz email"><br><br>
        <input type="password" name="password" value="{{old('password')}}" placeholder="Podaj hasło"><br><br>
        <input type="password" name="repassword" value="{{old('repassword')}}" placeholder="Powtórz hasło"><br><br>
        <input type="submit" value="Dodaj użytkownika">
    </form>

</body>
</html>
