   M S B A M L   `   `   `  ����E  AManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Management
Management  5          Management.ManagerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Management     5        N� Title$  ManagerPage��5	      .��5      � ��5   
   �� 5       �� ImageSource$ /Tryfog.jpeg��6    � RowDefinitions 5   
   �� 5      6   �� 5      $
��Auto �6   6,   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   .+�5      �� $��Task id��6   
�������$��30(�6;   $��Center=�6I   $��Center=�6f   6�   �� 5      -   5        $��idtxt��5      $��40��6$   $	��300��60   $��Center=�6>   $��Center=�6[   6y   5      �� 5   
   $ 
Horizontal=�6   $��1��6.   .+�5       �� $��Title��6   
�������$��30(�69   $��Center=�6G   $��Center=�6d   6�   �� 5!      -   5        $��titletxt��5!      $��40��6'   $	��300��63   $��Center=�6A   $��Center=�6^   6|   5"      �� 5#   
   $ 
Horizontal=�6   $��2��6.   .+�5$      �� $��Descripitoin��6   
�������$��30(�6@   $��Center=�6N   $��Center=�6k   6�   �� 5%      -   5        $��destxt��5%      $��40��6%   $	��300��61   $��Center=�6?   $��Center=�6\   6z   5&      �� 5'   
   $ 
Horizontal=�6   $��0��6.   $��1��6;   .+�5(      �� $��Status��6   
�������$��30(�6:   $��Center=�6H   $��Center=�6e   �� 5)      -   5        $
��Comp��5)      $��59��6#   $��80��6.   $��Right=�6:   .@�5+      �� $��	Completed��6   �� 5,      $��Pending��6   �� 5-      $��In progress��6   5.      5/      �� 50   
   $ 
Horizontal=�6   $��1��6.   $��1��6;   .+�51      �� $��Email��6   
�������$��30(�69   $��Center=�6G   $��Center=�6d   6�   �� 52      -   5        $��Emailtxt��52      $��40��6'   $	��300��63   $��Center=�6A   $��Center=�6^   6|   53      &   System.Windows.Controls.DataGrid  54   
   -   5        $	��DG1��54      $
��Left=�6   $��80��69   $	��500��6E   $��4��6Q   $	��Top=�6^   $��2��6v   $��
126,10,0,0q�6�   �� 55   
   $ 
Horizontal=�6   $��3��6/   $��Center=�6<   $��2��6W   $��
68,0,332,0q�6k   .+�56      �� -   5        $	��Add��56      6=   �� 57      -   5        $��Uptade��57      6?   �� 58      -	   5        $��Delate��58       J� RenderTransformOrigin$ 
0.65,0.631&�6;   5:      5<      5=      