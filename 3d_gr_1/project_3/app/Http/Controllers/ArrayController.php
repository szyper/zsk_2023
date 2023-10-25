<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class ArrayController extends Controller
{
    public function showArray(){
        $user = [
            'firstName' => 'Janusz',
            'lastName' => 'Nowak',
            'city' => 'Poznań',
            'hobby' => ['siatkówka', 'żużel', 'skoki narciarskie']
        ];
        return view('show_array', ['data' => $user]);
    }
}
