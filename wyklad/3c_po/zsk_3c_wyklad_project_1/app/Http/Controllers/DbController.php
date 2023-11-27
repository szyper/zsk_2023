<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\User;

class DbController extends Controller
{
    public function ShowTableUsers()
    {
        return User::all();
    }

    public function AddTableUsers(Request $req){
        return $req->input();
    }
}
