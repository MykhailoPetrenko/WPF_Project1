   M S B A M L   `   `   `  ����L  HKolokwiumPierwszy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:KolokwiumPierwszyKolokwiumPierwszy  5   	   "    KolokwiumPierwszy.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:KolokwiumPierwszy     5   	     � Title$  
MainWindow��5      $	��400��6   $	��600��6(   .��5
      � $��
0,0,0,-0.2q�6    � RowDefinitions 5      �� 5      $��169.667 �6   �� 5      $��30 �6   �� 5      $��34.667 �6   �� 5      $��36 �6   �� 5      $��40 �6   �� 5      $��36.667 �6    � ColumnDefinitions 5      �� 5      $	��75* �6   �� 5      $
��218* �6   �� 5      $	��94* �6   �� 5      $	��91* �6   �� 5      $
��117* �6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridPracownik��5         CanUserAddRows .     
IsReadOnly . $��10,2,10,28.2q�6Q   $��5��6g      AutoGenerateColumns .  $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6   	   Header$	 Employee��6#   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *ENAME+  5      $ * 6   $		 Job��6#   
 60   �� *JOB+  5      $ * 6   $	 Departament name��6#   
 6=   �� *
DEPT.DNAME+  5       $ * 6   $	 Salary��6#   
 63   �� *SAL+5"      �� 5$      $��2��6
   $��10,170,147.8,4.2q�6   $��2��68   .��6I   Dodaj pracownika6[   �� 5%      $��5,6.8,4.2,34.6q�6
   $��2��6"   $��2��6/   .��6@   Ename6G   �� 5&      $��23,5.2,10.2,2.6q�6
   $��3��6#   .��60   Job65   �� 5'      $��0,6.4,0,1.4q�6
   $��4��6   $
��Left=�6,   $��81��6G   $��2��6R   .��6f   Departament6s   �� 5(      $��11.2,9.8,21.8,0.8q�6
    J� RenderTransformOrigin$ 0.368,1.296&�6%   $��2��6I   $��2��6Y   .��6f   Szukaj6n   �� 5*      -   5         ��Name$ Nazwisko��5*      $��70.2,6.8,17,2.8q�6   $ 0.763,1.176&�67   $��2��6[   $��2��6k   $��3��6x   �� 5+      -   5        $ 
TextBoxEmp��5+      $��9.8,6.8,93.8,3.8q�6    $��2��6:   $��1��6G   $��2��6W   �� 5,      -   5        $ 
TextBoxJob��5,      $��9.8,9.2,93.8,1.6q�6    $��3��6:   $��1��6G   $��2��6W   �� 5.      -   5         ��Name$ ComboBoxDname��5.       �� Text$ Select dzial��6$    �� 
IsEditable .  �� 
IsReadOnly . $��9.8,8.4,93.8,5.4q�6\   $��4��6v   $��1��6�   $��2��6�   �� 50      -   5        $��1��50      $��126.8,2.6,85.8,10q�6   $��5��66   $ 0.5,0.5&�6C   $��2��6c   .��6�   Dodaj6�   �� 51      -   5        $��4��51      $��4��6   $��Delete��6)   $��2.831,40.4,17.369,10q�6:   $��2��6X   6i   �� 52      -   5        $��2��52      $��70.062,11.2,27.169,0.6q�6   $��3��6Q   $��2��6^   .��6r   Szukaj6z   �� 53      -	   5        $��4��53      $��3.831,9.2,17.369,0.6q�6   $��3��6X   .��6e   Pokaz wszystkich6w   54      56      