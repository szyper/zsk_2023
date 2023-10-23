<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class ShowController extends Controller
{
    public function show(){
      return 'Kontroler ShowController';
    }

    public function showView(){
      $users = [
        'firstName' => 'Janusz',
        'lastName' => 'Nowak',
        'city' => 'Poznań',
        'hobby' => ['siatkówka', 'skoki narciarskie', 'żużel', 'piłka ręczna']
      ];
      return View('users', $users);
    }

  public function showArray(){
    $users = [
      'firstName' => 'Janusz',
      'lastName' => 'Nowak',
      'city' => 'Poznań',
      'hobby' => ['siatkówka', 'skoki narciarskie', 'żużel', 'piłka ręczna']
    ];
    return View('usersarray', ['users' => $users]);
  }

}
