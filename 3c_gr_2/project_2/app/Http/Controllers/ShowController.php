<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class ShowController extends Controller
{
    public function show(){
        return 'Kontroler ShowController';
    }

    public function showFirstName(){
        $data = [
            'firstName' => 'Janusz',
            'lastName' => 'Nowak',
            'city' => 'Poznań',
        ];
        return View('data', $data);
    }
}
