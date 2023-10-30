<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UserFormController extends Controller
{
    public function showUser(Request $req){
      $req->validate([
        'firstName' => 'required | min:2 | max:15',
        'lastName' => 'required | min:2 | max:30',
        'email' => 'required | min:5 | max:15 | email',
      ]);
//      return $req->input();
//      return $req->input('email');

      $user = [
        'firstName' => $req->input('firstName'),
        'lastName' => $req->input('lastName'),
        'email' => $req->input('email')
      ];

      return view('user', ['user' => $user]);
    }
}
