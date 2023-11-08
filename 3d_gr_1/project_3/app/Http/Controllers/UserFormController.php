<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UserFormController extends Controller
{
    public function showUser(Request $req){
//        return $req->input(); //{"firstName":"Janusz","lastName":"Nowak"}
//        return $req->path(); //UserFormController
//          return $req->url(); //http://127.0.0.1:8000/UserFormController
//          return $req->method(); //GET
//          return $req->all(); //{"firstName":"Janusz","lastName":"Nowak"}

        $req->validate([
            'firstName' => 'required | min:3 | max:10',
            'lastName' => 'required | min:3 | max:20',
            'mail' => 'required | min:3 | max:20 | email',
        ],
        [

        ]);

        $user = [
            'firstName' => $req->input('firstName'),
            'lastName' => $req->input('lastName'),
            'mail' => $req->input('mail')
        ];
        return view('user', $user);
    }
}
