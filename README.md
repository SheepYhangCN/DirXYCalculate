| Languages |
|-|
| **English**, [简体中文](README_sChs.md), [繁體中文](README_tChs.md), [日本語](README_Ja.md)|
# How to use
Add ```Using SheepYhangCN.DirXYCalculate;``` at the head of your C# file

## LengthDir
```Target.X+=DirXYCalculate.LengthDirX(Angle,Range to target);```<br>
```Target.Y+=DirXYCalculate.LengthDirY(Angle,Range to target);```

## PointDirection
```Target.Angle=DirXYCalculate.PointDirection(X of this point,Y of this point,X of target point,Y of target point);```

# About ```DegreesRadians.cs```
Check [SheepYhangCN/DegreesRadians](https://github.com/SheepYhangCN/DegreesRadians) <br>
If you don't want ```DegreesRadians.cs```, then use ```DirXYCalculate_NeedntDegreesRadiansFunc.cs``` instead of ```DirXYCalculate.cs```