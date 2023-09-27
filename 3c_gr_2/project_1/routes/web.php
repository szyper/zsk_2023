<?php

use App\Http\Controllers\ProfileController;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group. Make something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});

Route::get('/dashboard', function () {
    return view('dashboard');
})->middleware(['auth', 'verified'])->name('dashboard');

Route::middleware('auth')->group(function () {
    Route::get('/profile', [ProfileController::class, 'edit'])->name('profile.edit');
    Route::patch('/profile', [ProfileController::class, 'update'])->name('profile.update');
    Route::delete('/profile', [ProfileController::class, 'destroy'])->name('profile.destroy');
});

require __DIR__.'/auth.php';

Route::get('/city_old', function(){
    return "Miasto";
});

Route::get('city', function(){
   return view('city');
});

//Route::redirect('/', '/city_old');
//Route::redirect('/', '/city', 301);
Route::get('/status',  function(){
    $response = Response::json([
        'error' => false,
        'code' => 203,
        'message' => 'all good!!!! '
    ], 500);
    return $response->status();
});

Route::get('city2', function(){
//    return ["name" => "Janusz", "city" => "Poznan"];
    return view('city', ["name" => "Janusz", "city" => "Poznan"]);
});

Route::get('page/{x}', function($x){
    return $x;
});

Route::get('pages/{x}', function($x){
    $info = [
        'about' => 'Informacje o stronie',
        'contact' => 'contact@o2.pl',
        'home' => 'Strona domowa'
    ];
    return $info[$x];
});

/*
Route::get("/address/{city}", function(string $city){
    echo "Miasto: $city";
});

Route::get("/address1/{city}/{street}", function(string $city, string $street){
    echo <<< ADDRESS
       Miasto: $city<br>
       Ulica: $street
       <hr>
ADDRESS;
});

Route::get("/address2/{city}/{street}/{zipCode}", function(string $city, string $street, int $zipCode){
  $zipCode = substr($zipCode, 0, 2)."-".substr($zipCode, 2, 3);
  echo <<< ADDRESS
       Kod pocztowy: $zipCode<br>
       Miasto: $city<br>
       Ulica: $street
       <hr>
ADDRESS;
});
*/

/*
Route::get("/address3/{city}/{street}/{zipCode?}", function(string $city, string $street, int $zipCode = null){
  if (is_null($zipCode))
    $zipCode = "brak danych";
  else
    $zipCode = substr($zipCode, 0, 2)."-".substr($zipCode, 2, 3);

  echo <<< ADDRESS
       Kod pocztowy: $zipCode<br>
       Miasto: $city<br>
       Ulica: $street
       <hr>
ADDRESS;
});
*/

Route::get("/address3/{city?}/{street?}/{zipCode?}", function(string $city = "-", string $street = "-", int $zipCode = null){
  if (is_null($zipCode))
    $zipCode = "brak danych";
  else
    $zipCode = substr($zipCode, 0, 2)."-".substr($zipCode, 2, 3);

  echo <<< ADDRESS
       Kod pocztowy: $zipCode<br>
       Miasto: $city<br>
       Ulica: $street
       <hr>
ADDRESS;
})->name('x');

Route::redirect('/danemiasta/{city?}/{street?}/{zipCode?}', '/address3/{city?}/{street?}/{zipCode?}');

Route::redirect('stronaglowna', '/');
Route::redirect('xyz', 'stronaglowna');

