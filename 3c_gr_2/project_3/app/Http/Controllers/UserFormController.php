<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UserFormController extends Controller
{
    public function showUser(Request $req){
        //return $req->input(); //{"firstName":"Janusz","lastName":"Nowak"}
//        return $req->input('firstName'); //Janusz
//        return $req->path(); //UserFormController
//        return $req->url(); //http://127.0.0.1:8000/UserFormController
//        return $req->method(); //GET
//        return $req->all(); //{"firstName":"Janusz","lastName":"Nowak"}

    $req->validate([
        'firstName' => 'required | min:5 | max: 10',
        'lastName' => 'required | min:3 | max: 20',
        'mail' => 'required | email',
    ],
    [
       /* 'firstName.required' => 'Pole :attribute jest wymagane',
        'firstName.min' => 'Pole :attribute musi mieć minimum :min znaki',
        'firstName.max' => 'Pole :attribute musi mieć maksimum :max znaków',
        'lastName.required' => 'Pole :attribute jest wymagane',
        'lastName.min' => 'Pole :attribute musi mieć minimum :min znaki',
        'lastName.max' => 'Pole :attribute musi mieć maksimum :max znaków',
        'mail.required' => 'Pole :attribute jest wymagane',
        'mail.email' => 'Pole :attribute musi być typu email',*/
    ]);

    $dataUser = [
        'firstName' => $req->input('firstName'),
        'lastName' => $req->input('lastName'),
        'mail' => $req->input('mail'),
    ];

    return view('user', ['user' => $dataUser]);

    }
}
