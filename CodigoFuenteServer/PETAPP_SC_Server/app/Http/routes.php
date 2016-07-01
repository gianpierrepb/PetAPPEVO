<?php


Route::get('/ie', function () {
    return view('welcome');
});

Route::group(['middleware' => ['web']], function() {

    Route::group(['prefix' => '/api'], function () {

        Route::post('/login', ['as' => 'userAuthentication', 'uses' => 'SessionController@login']
        );
        Route::post('/logout', ['as' => 'userLogout', 'uses' => 'SessionController@userLogout']
        );
        Route::post('/create/user', ['as' => 'userCreate', 'uses' => 'SessionController@create']
        );
        Route::post('/create/dogs', ['as' => 'userCreateDogs', 'uses' => 'SessionController@createDog']
        );
    });
});
