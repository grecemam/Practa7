   M S B A M L   `   `   `  ����G  CDentalClinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DentalClinicDentalClinic  5      (    "DentalClinic.ScheduleEmployeesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      &localclr-namespace:DentalClinic  5        N� Title$1  +Управление расписанием��5
       N� 
FontFamily$ Bahnschrift)�6&   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��1��6    � ColumnDefinitions 5      �� 5      $��3* �6#   �� 5      $��2* �6#   .+�5      �� $��5q�6      MaterialDesignGroupBox#��[  6"   .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Custom=�6R      
Background �	#FF0A1129   
Foreground
 �����$��Сотрудники��5   I   $��0��6]   .��5      �� .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ EmployeesDataGrid��5         AutoGenerateColumns .  	   
IsReadOnly	 . ���	#FF0A1129
�������$
��auto��5"      $��5q�6-   
   Columns
 5#      0  *System.Windows.Controls.DataGridTextColumn  5$         
Foreground
 �����,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *schedule_id+   Header 5%   "   �� 5&   &   $��ID��60   
�������6:   5(        5)      
 �����$	 100 6e    6D   �� *EmployeeName+ 5*   "   �� 5+   &   $��Имя��60   
�������6;   5-        5.      
 �����$	 100 6i    6D   �� *EmployeeLastName+ 5/   "   �� 50   &   $��Фамилия��60   
�������6?   52        53      
 �����$	 130 6`    6D   �� *	DayName+ 54   "   �� 55   &   $��День��60   
�������6<   57        58      
 �����$	 150 6b    6D   �� *	ShiftTime+ 59   "   �� 5:   &   $��
Время��60   
�������6=   5<      5>      5?      5@      �� 5C      $+��%Изменить расписание��6   
�������#��[  6G   $ Custom=�6w    �	#FF0A1129
 �����$��5q�5E   I   $��1��6T   .��5F      �� .+�5G      �� $��День недели:��6    $��5q�64   
���   �6?   �� 5H      -   5         ��Name$ DayComboBox��5H      $��5q�64   $	��200��6?    �� DisplayMemberPath$ DayName��5I      
���   � �� SelectedValuePath$ DayId��6N   �� 5K      $��Смена:��6    $��5q�6.   
���   �69   �� 5L      -   5        $ ShiftComboBox��5L      $��5q�66   $	��200��6A   $ 	ShiftTime��5M      
���   �$ ShiftId��6P   �� 5O      -   5        $+��%Обновить расписание��5O      $��5q�5P      $	��200��6(   ���	#FF0A1129���	#FF050C315R   4   �� 5T      -   5         ��Name$ StatusTextBlock��5T       $�� ��5U       $��5q�6(   
��� � �63   5V      5W      5X      5Y      5Z      