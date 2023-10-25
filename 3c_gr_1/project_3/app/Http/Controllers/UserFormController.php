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

        $data = [
            'firstName' => $req->input('firstName'),
            'lastName' => $req->input('lastName'),
        ];

        return view('user', $data);

    }
}
