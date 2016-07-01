<?php


namespace App\Http\Controllers;

use App\User;

use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;
use JWTAuth;
use Tymon\JWTAuth\Exceptions\JWTException;
use App\Http\Requests;
use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use Validator;
use Auth;
use Illuminate\Foundation\Auth\ThrottlesLogins;
use Illuminate\Foundation\Auth\AuthenticatesAndRegistersUsers;

class SessionController  extends Controller
{
	public function login( Request $request)
	{
		$credentials = $request->only('email', 'password');

		if(Auth::attempt($credentials)) {
			$user = Auth::user();
			$user_response = $this->userResponse($user);
			return response()->json($user_response,200);
		} else {
			$response = "there are incorrect credentials ";
			return response()->json($response,422);
		}
	}

	private function userResponse($user = null)
	{

		$user_responses = [];

		if($user != null) {
			$user_responses= [
				'name' => $user->name,
				'email' => $user->email
			];
		}
		return $user_responses;
	}

	private function setUpUser($name , $email, $password)
	{

		$user_array = [];

		$user_array= [
			'name' => $name,
			'email' => $email,
			'password' =>$password,
			'remember_token'=> NULL
		];

		return $user_array;
	}


	public function userLogout()
	{
		Auth::logout();
		$response = "Session ended";
		return response()->json($response,200);
	}

	public function create( Request $request)
	{
		$name = $request->only('name');
		$email = $request->only('name');
		$password = $request->only('name');
		$password = Hash::make($password);

		$user_array = $this->setUpUser($name, $email, $password);

		$user_id = DB::table('users')->insertGetId($user_array);

		$response = "the user with ID ".$user_id." have been created ";

		return response()->json($response,200);

	}

}
