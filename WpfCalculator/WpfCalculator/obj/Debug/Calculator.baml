   M S B A M L   `   `   `  ����  WpfCalculator    WpfCalculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
Calculator��5   	   $	��400��6   $	��300��6)   .��5      � $��	0,0,-8,11q�6    � ColumnDefinitions 5	   
   �� 5
      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ button7��5      $��2��6"   $��0��6/   .��6U   76X   �� 5   
   -   5        $ button8��5      $��2��6"   $��1��6/   .��6U   86X   �� 5   
   -   5        $ button9��5      $��2��6"   $��2��6/   .��6U   96X   �� 5   
   -   5        $ button4��5      $��3��6"   $��0��6/   .��6U   46X   �� 5   
   -   5        $ button5��5      $��3��6"   $��1��6/   .��6U   56X   �� 5   
   -   5        $ button6��5      $��3��6"   $��2��6/   .��6U   66X   �� 5   
   -   5        $ button1��5      $��4��6"   $��0��6/   .��6U   16X   �� 5    
   -   5        $ button2��5       $��4��6"   $��1��6/    J� RenderTransformOrigin$ 0.5,0.5&�6U   z�5!      V� 5"      .~�5#      �� �� 5$      �� 5%       �� Angle$
 1.55Q�6&   T� 5&      5'      .��5(   &   25)      �� 5*   
   -	   5        $ button3��5*      $��4��6"   $��2��6/   .��6U   36X   �� 5+   
   -
   5        $ button0��5+      $��5��6"   $��1��6/   .��6U   06X   �� 5-   
   -   5        $ buttonPositive��5-      $��1��6)   $��3��66   .��6c   +6f   �� 5.   
   -   5        $ buttonNegative��5.      $��2��6)   $��3��66   .��6c   -6f   �� 5/   
   -   5        $ buttonMultiply��5/      $��3��6)   $��3��66   .��6c   *6f   �� 50   
   -   5        $ buttonDivison��50      $��4��6(   $��3��65   .��6a   /6d   �� 51   
   -   5        $ buttonEqualTo��51      $��5��6(   $��3��65   $��59��6a   $��Bottom=�6m   .��6�   =6�   �� 53   
   -   5        $ buttonClearEntry��53      $��1��6+   $��0��68   .��6g   CE6k   �� 54   
   -   5        $ buttonClear��54      $��1��6&   $��1��63   .��6]   C6`   �� 56   
   -   5        $ buttonBackSpace��56      $��1��6*   $��2��67   $��<=��6G   6w   �� 58   
   -   5        $ buttonPositiveNegative��58      $��5��61   $��0��6>   .��6s   +-6w   �� 5:   
   -   5         ��Name$ textDisplay��5:       �� 
IsReadOnly .  �� TextAlignment$ Right=�69   $��30(�6O   $��Bottom=�6]   $��0q�6x   $��0��6�   $��0��6�   $��4��6�   .��6�   06�   5<      5=      