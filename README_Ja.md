# 使い方
```using SheepYhangCN.DirXYCalculate;``` をあなたのC＃ファイルの先頭に追加してください。

## LengthDir
```Target.X+=DirXYCalculate.LengthDirX(角度,目標までの距離);```<br>
```Target.Y+=DirXYCalculate.LengthDirY(角度,目標までの距離);```

## PointDirection
```Target.Angle=DirXYCalculate.PointDirection(現在のX,現在のY,目標のX,目標のY);```

# ```DegreesRadians.cs``` について
[SheepYhangCN/DegreesRadians](https://github.com/SheepYhangCN/DegreesRadians) を見る<br>
```DegreesRadians.cs``` が必要ない場合は、```DirXYCalculate.cs``` を使用せず、```DirXYCalculate_NeedntDegreesRadiansFunc.cs``` を使用してください。