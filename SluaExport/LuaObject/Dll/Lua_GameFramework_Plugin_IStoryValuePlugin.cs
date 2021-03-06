﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_GameFramework_Plugin_IStoryValuePlugin : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetProxy(IntPtr l) {
		try {
			GameFramework.Plugin.IStoryValuePlugin self=(GameFramework.Plugin.IStoryValuePlugin)checkSelf(l);
			StorySystem.StoryValueResult a1;
			checkType(l,2,out a1);
			self.SetProxy(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Evaluate(IntPtr l) {
		try {
			GameFramework.Plugin.IStoryValuePlugin self=(GameFramework.Plugin.IStoryValuePlugin)checkSelf(l);
			StorySystem.StoryInstance a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			System.Object[] a3;
			checkArray(l,4,out a3);
			self.Evaluate(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadCallData(IntPtr l) {
		try {
			GameFramework.Plugin.IStoryValuePlugin self=(GameFramework.Plugin.IStoryValuePlugin)checkSelf(l);
			Dsl.CallData a1;
			checkType(l,2,out a1);
			self.LoadCallData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadFuncData(IntPtr l) {
		try {
			GameFramework.Plugin.IStoryValuePlugin self=(GameFramework.Plugin.IStoryValuePlugin)checkSelf(l);
			Dsl.FunctionData a1;
			checkType(l,2,out a1);
			self.LoadFuncData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadStatementData(IntPtr l) {
		try {
			GameFramework.Plugin.IStoryValuePlugin self=(GameFramework.Plugin.IStoryValuePlugin)checkSelf(l);
			Dsl.StatementData a1;
			checkType(l,2,out a1);
			self.LoadStatementData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"GameFramework.Plugin.IStoryValuePlugin");
		addMember(l,SetProxy);
		addMember(l,Evaluate);
		addMember(l,LoadCallData);
		addMember(l,LoadFuncData);
		addMember(l,LoadStatementData);
		createTypeMetatable(l,null, typeof(GameFramework.Plugin.IStoryValuePlugin));
	}
}
