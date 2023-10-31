<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class AddUserController extends Controller
{
    public function ShowUser(Request $req){
      //return $req->input();
      //return $req->input('email');
      //return $req->path();
      //return $req->url();
      return $req->method();

    }
}
