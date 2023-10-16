<?php

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

Route::middleware([
    'auth:sanctum',
    config('jetstream.auth_session'),
    'verified',
])->group(function () {
    Route::get('/dashboard', function () {
        return view('dashboard');
    })->name('dashboard');
});

//prefix, group
Route::get('/user/contact/{userId}', function(int $userId){
    return 'Kontakt do użytkownika '.$userId;
});

Route::prefix('admin')->group(function(){
  Route::get('/admin/users', function(){
    return '<h3>Użytkownicy</h3>';
  });

  Route::get('/admin/home', function(){
    return '<h3>Strona domowa</h3>';
  });
});

Route::redirect('/admin', '/admin/home');
