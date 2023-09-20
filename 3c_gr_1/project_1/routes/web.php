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

Route::get('city_old', function(){
    return 'Miasto';
});

Route::get('city', function(){
    return view('city');
});

Route::get('info', function(){
    return view('info', ['firstName' => 'Janusz', 'lastName' => 'Nowak', 'city' => 'Poznan']);
});

Route::get('info_age/{age}', function($age){
    return view('info', ['firstName' => 'Janusz', 'lastName' => 'Nowak', 'city' => 'Poznan', 'age' => $age]);
});

Route::get('pages/{page}', function($page){
    $pages = [
        'about' => 'Informacje o stronie',
        'contact' => 'contact@gmail.com',
        'home' => 'Strona domowa'
    ];
    return $pages[$page];
});

Route::redirect('miasto', 'city');
Route::redirect('/', 'city');
