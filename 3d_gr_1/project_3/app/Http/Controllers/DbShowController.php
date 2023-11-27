<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;

class DbShowController extends Controller
{
    public function ShowDb(){
        //return DB::table('users')->get();
//        return DB::table('users')
//            ->select('name', 'email')
//            ->get();

        return DB::table('users')
            ->insert([
               'name' => 'anna',
               'email' => 'anna@o2.pl1',
               'password' => Hash::make('anna')
            ]);
    }
}
