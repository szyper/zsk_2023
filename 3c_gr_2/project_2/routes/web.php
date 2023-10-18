<?php
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\ShowController;

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

Route::get('show', [\App\Http\Controllers\ShowController::class, 'show']);
Route::get('data', [ShowController::class, 'showFirstName']);

//dodać tablice do kontrolera i wyswietlic dane w foreach
