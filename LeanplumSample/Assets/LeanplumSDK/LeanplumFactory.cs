﻿//
// Copyright 2014, Leanplum, Inc.
//
//  Licensed to the Apache Software Foundation (ASF) under one
//  or more contributor license agreements.  See the NOTICE file
//  distributed with this work for additional information
//  regarding copyright ownership.  The ASF licenses this file
//  to you under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing,
//  software distributed under the License is distributed on an
//  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
//  KIND, either express or implied.  See the License for the
//  specific language governing permissions and limitations
//  under the License.
using UnityEngine;
using System.Collections;

namespace LeanplumSDK 
{
	public class LeanplumFactory
	{
		private static LeanplumSDKObject _sdk = null;

		public static LeanplumSDKObject SDK
		{
			set {}
			get
			{
				if (_sdk == null) 
				{
					#if UNITY_EDITOR
					_sdk = new LeanplumNative();
					#elif UNITY_IPHONE
					_sdk = new LeanplumIOS();
					#elif UNITY_ANDROID
					_sdk = new LeanplumAndroid();
					#else
					_sdk = new LeanplumNative();
					#endif
				}
				
				return _sdk;
			}
		}
	}
}
