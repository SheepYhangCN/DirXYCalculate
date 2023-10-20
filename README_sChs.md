# 如何使用
把 ```Using SheepYhangCN.DirXYCalculate;``` 添加到你C#文件的开头

## LengthDir
```Target.X+=DirXYCalculate.LengthDirX(角度,到目标点的距离);```<br>
```Target.Y+=DirXYCalculate.LengthDirY(角度,到目标点的距离);```

## PointDirection
```Target.Angle=DirXYCalculate.PointDirection(当前X,当前Y,目标X,目标Y);```

# 关于 ```DegreesRadians.cs```
详见 [SheepYhangCN/DegreesRadians](https://github.com/SheepYhangCN/DegreesRadians) <br>
如果你不想要 ```DegreesRadians.cs```，那么就不要使用 ```DirXYCalculate.cs``` 而是用 ```DirXYCalculate_NeedntDegreesRadiansFunc.cs```