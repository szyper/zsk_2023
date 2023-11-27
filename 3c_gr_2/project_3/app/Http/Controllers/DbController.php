<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;

class DbController extends Controller
{
    public function ShowTableUser(){
        //return DB::table('users')->get();
//        return DB::table('users')
//            ->select('name', 'email')
//            ->where('name', '=', 'jan')
//            ->get();

        return DB::table('users')
            ->insert([
                'name' => 'krystyna',
                'email' => 'krystyna@o2.pl12',
                'password' => Hash::make('krystyna@o2.pl12')
            ]);
    }
}
