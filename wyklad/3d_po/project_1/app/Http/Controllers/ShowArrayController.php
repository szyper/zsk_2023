<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class ShowArrayController extends Controller
{
    public function show(string $key = null, string $firstName = '-', string $lastName = '-'){
      $user = [
        'firstName' => $firstName,
        'lastName' => $lastName,
        'key' => $key,
        'colors' => ['red', 'blue', 'green']
      ];

      return View('show.array', ['users' => $user]);
    }
}
