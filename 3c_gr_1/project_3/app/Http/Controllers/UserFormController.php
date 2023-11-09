<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UserFormController extends Controller
{
    public function ShowUser(Request $req){
//        return $req->input(); //{"firstName":"Krystyna","lastName":"Nowak"}
//        return $req->input('firstName'); // Krystyna
//        return $req->all(); // {"firstName":"Krystyna","lastName":"Nowak"}
//        return $req->method(); //GET
//        return $req->url(); //http://127.0.0.1:8000/UserFormController
//        return $req->path(); //UserFormController

        $req->validate([
            'firstName' => 'required | min:3 | max:10',
            'lastName' => 'required | min:3 | max:20',
            'mail' => 'required | min:3 | max:20 | email',
        ],
        [
            /*'firstName.required' => 'Wypełnij pole :attribute',
            'firstName.min' => 'Pole :attribute musi mieć minimum :min znaki',
            'firstName.max' => 'Pole :attribute może mieć maksymalnie :max znaków',
            'lastName.required' => 'Wypełnij pole :attribute',
            'lastName.min' => 'Pole :attribute musi mieć minimum :min znaki',
            'lastName.max' => 'Pole :attribute może mieć maksymalnie :max znaków',
            'mail.required' => 'Wypełnij pole :attribute',
            'mail.min' => 'Pole :attribute musi mieć minimum :min znaki',
            'mail.max' => 'Pole :attribute może mieć maksymalnie :max znaków',
            'mail.email' => 'Pole :attribute musi być typu email',*/
        ]);

        $data = [
            'firstName' => $req->input('firstName'),
            'lastName' => $req->input('lastName'),
            'mail' => $req->input('mail'),
        ];

        return view('user', $data);

    }
}
