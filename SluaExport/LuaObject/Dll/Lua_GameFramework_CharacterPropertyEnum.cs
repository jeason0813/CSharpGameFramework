﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_GameFramework_CharacterPropertyEnum : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"GameFramework.CharacterPropertyEnum");
		addMember(l,1001,"x1001_基础物理攻击");
		addMember(l,1002,"x1002_物理攻击成长");
		addMember(l,1003,"x1003_物理攻击加成");
		addMember(l,1004,"x1004_额外物理攻击");
		addMember(l,1005,"x1005_最终物理攻击");
		addMember(l,1006,"x1006_基础法术攻击");
		addMember(l,1007,"x1007_法术攻击成长");
		addMember(l,1008,"x1008_法术攻击加成");
		addMember(l,1009,"x1009_额外法术攻击");
		addMember(l,1010,"x1010_最终法术攻击");
		addMember(l,1011,"x1011_基础物理防御");
		addMember(l,1012,"x1012_物理防御成长");
		addMember(l,1013,"x1013_物理防御加成");
		addMember(l,1014,"x1014_额外物理防御");
		addMember(l,1015,"x1015_最终物理防御");
		addMember(l,1016,"x1016_基础法术防御");
		addMember(l,1017,"x1017_法术防御成长");
		addMember(l,1018,"x1018_法术防御加成");
		addMember(l,1019,"x1019_额外法术防御");
		addMember(l,1020,"x1020_最终法术防御");
		addMember(l,1021,"x1021_暴击等级");
		addMember(l,1022,"x1022_抗暴击等级");
		addMember(l,1023,"x1023_额外暴击率");
		addMember(l,1024,"x1024_命中等级");
		addMember(l,1025,"x1025_额外命中率");
		addMember(l,1026,"x1026_闪避等级");
		addMember(l,1027,"x1027_额外闪避率");
		addMember(l,1028,"x1028_破击等级");
		addMember(l,1029,"x1029_额外破击概率");
		addMember(l,1030,"x1030_格挡等级");
		addMember(l,1031,"x1031_额外格挡概率");
		addMember(l,1032,"x1032_格挡强度");
		addMember(l,1033,"x1033_暴击伤害");
		addMember(l,1034,"x1034_暴击伤害减免");
		addMember(l,1035,"x1035_伤害加成_百分比");
		addMember(l,1036,"x1036_伤害加成_定值");
		addMember(l,1037,"x1037_伤害减免_百分比");
		addMember(l,1038,"x1038_伤害减免_定值");
		addMember(l,1039,"x1039_忽略物理防御");
		addMember(l,1040,"x1040_忽略法术防御");
		addMember(l,1041,"x1041_属性攻击预留");
		addMember(l,1042,"x1042_属性攻击预留");
		addMember(l,1043,"x1043_属性攻击预留");
		addMember(l,2001,"x2001_基础生命");
		addMember(l,2002,"x2002_生命成长");
		addMember(l,2003,"x2003_生命加成");
		addMember(l,2004,"x2004_额外生命");
		addMember(l,2005,"x2005_最大生命值");
		addMember(l,2006,"x2006_当前生命值");
		addMember(l,2007,"x2007_基础速度");
		addMember(l,2008,"x2008_速度成长");
		addMember(l,2009,"x2009_速度加成");
		addMember(l,2010,"x2010_额外速度");
		addMember(l,2011,"x2011_最终速度");
		addMember(l,2012,"x2012_护盾值");
		addMember(l,3001,"x3001_眩晕");
		addMember(l,3002,"x3002_昏睡");
		addMember(l,3003,"x3003_倒地");
		addMember(l,3004,"x3004_减速");
		addMember(l,3005,"x3005_浮空");
		addMember(l,3006,"x3006_灼烧");
		addMember(l,3007,"x3007_感电");
		addMember(l,3008,"x3008_霸体");
		addMember(l,3009,"x3009_无敌");
		addMember(l,3010,"x3010_复活");
		addMember(l,3011,"x3011_隐身");
		addMember(l,4001,"x4001_职业");
		addMember(l,4002,"x4002_阵营");
		addMember(l,4003,"x4003_品质");
		addMember(l,4004,"x4004_性别");
		addMember(l,5001,"x5001_等级");
		addMember(l,5002,"x5002_经验");
		addMember(l,5003,"x5003_SC最大值");
		addMember(l,5004,"x5004_SC当前值");
		addMember(l,5005,"x5005_UC最大值");
		addMember(l,5006,"x5006_UC当前值");
		LuaDLL.lua_pop(l, 1);
	}
}
