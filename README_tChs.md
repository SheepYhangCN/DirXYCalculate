# 如何使用
把 ```Using SheepYhangCN.DirXYCalculate;``` 添加到你C#檔案的開頭

## LengthDir
```Target.X+=DirXYCalculate.LengthDirX(角度,到目標點的距離);```<br>
```Target.Y+=DirXYCalculate.LengthDirY(角度,到目標點的距離);```

## PointDirection
```Target.Angle=DirXYCalculate.PointDirection(當前X,當前Y,目標X,目標Y);```

# 關於 ```DegreesRadians.cs```
詳見 [SheepYhangCN/DegreesRadians](https://github.com/SheepYhangCN/DegreesRadians) <br>
如果你不想要 ```DegreesRadians.cs```，那麼就不要使用 ```DirXYCalculate.cs``` 而是用 ```DirXYCalculate_NeedntDegreesRadiansFunc.cs```