<?php

use App\Http\Controllers\ProfileController;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\showTableController;
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

Route::get('zsk', function(){
  return view('zsk', [
    'firstName' => 'Janusz',
    'lastName' => 'Nowak',
    'city' => 'Gniezno'
  ]);
});

Route::view('test', 'welcome');

/*
Route::get('drives/{drive}', function(string $drive){
  $drives = [
    'fdd' => 'dyskietka',
    'hdd' => 'dysk HDD',
    'ssd' => 'dysk SSD'
  ];
  return $drives[$drive]??'Błędne dane podane przez użytkownika';
});
*/

Route::get('drives/{drive}', function(string $drive){
  $drives = match($drive){
    'fdd' => 'dyskietka',
    'hdd' => 'dysk HDD',
    'ssd' => 'dysk SSD',
    default => 'Błędne dane podane przez użytkownika'
  };
  return $drives;
});

Route::get('address', function(){
  echo <<< ADDRESS
    Miasto:
ADDRESS;
});

Route::get('address1/{city}', function(string $city){
  echo <<< ADDRESS
    Miasto: $city
ADDRESS;
});

Route::get('address2/{city?}', function(string $city = null){
  echo <<< ADDRESS
    Miasto: $city
ADDRESS;
});


Route::prefix('users')->group(function(){
  Route::get('/list', function(){
    return 'Strona z użytkownikami';
  });

  Route::get('/home', function(){
    return 'Strona domowa użytkownika';
  });
});


Route::prefix('admin')->group(function(){
  Route::get('/list_users', function(){
    return 'Lista użytkowników';
  });

  Route::get('/home', function(){
    return 'Strona domowa admina';
  });
});

Route::prefix('moderator')->group(function(){
  Route::get('/list', function(){
    return 'Strona z artykułami';
  });

  Route::get('/home', function(){
    return 'Strona domowa moderatora';
  });
});



Route::name('admin.')->group(function () {
  Route::get('/users1', function () {
    return 'strona administracyjna';
  })->name('users');
});

Route::get('show', [\App\Http\Controllers\showController::class, 'show']);

Route::get('site', [showTableController::class, 'showDashboard']);

Route::get('showarray/{key?}/{firstName?}/{lastName?}', [\App\Http\Controllers\ShowArrayController::class, 'show']);

Route::view('userform', 'forms.userform');
