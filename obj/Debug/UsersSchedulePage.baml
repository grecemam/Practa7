   M S B A M L   `   `   `  ����  DentalClinic$    DentalClinic.UsersSchedulePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5        N� Title$+  %Управление Записями��5	       N� 
FontFamily$ Bahnschrift)�6#   .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $��2* �6   .+�5   
   �� $!��Список записей��6   $��5q�6+   $��5q�66      MaterialDesignGroupBox#��[  6B   .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Custom=�6r      
Background �	#FF0A1129   
Foreground
 �����.��5      &   System.Windows.Controls.DataGrid  -   5          Name$ AppointmentsDataGrid��5         AutoGenerateColumns .     
IsReadOnly . 	   SelectionMode$	 Single=�5      ���	#FF0A1129$
��auto��5      
�������
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *appointment_id+   Header 5      �� 5       $��ID��6(   
�������62   5"        5#      $	 170 6I    6)   �� *PatientName+ 5$      �� 5%      $��Пациент��6(   
�������67   5'        5(      $	 180 6H    6)   �� *
DoctorName+ 5)      �� 5*      $��Врач��6(   
�������64   5,        5-      $	 100 6o    6)   �� *appointment_date+ �� StringFormat$ {0:dd/MM/yyyy}�� 5.      �� 5/      $��Дата��6(   
�������64   51        52      $ 80 6N    6)   �� *appointment_time+ 53      �� 54      $��
Время��6(   
�������65   56        57      $	 120 6D    6)   �� *Status+ 58      �� 59      $��Статус��6(   
�������66   5;      5=      5>      �� 5A   
   $)��#Управление записью��6   #��[  6/   $ Custom=�6_    �	#FF0A1129
 �����$��1��5C   I   $��5q�6Y   $��10q�6d   .��5D      �� .+�5E      ��  �� Orientation$ 
Horizontal=�6   $	��0,5q�66   .+�5F      �� $��	Врач:��6    
���   �$	��100��6@   $	��Top=�6L   �� 5G      -   5         ��Name$ DoctorsComboBox��5G      $	��200��68   5H      �� 5J      $ 
Horizontal=�6   $	��0,5q�66   .+�5K      �� $��	Дата:��6    
���   �$	��100��6@   $��Center=�6L   (  "System.Windows.Controls.DatePicker  5L      -   5          Name$ AppointmentDatePicker��5L   !   $	��200��6@   6L   5M      �� 5N      $ 
Horizontal=�6   $	��0,5q�66   .+�5O      �� $��Время:��6    
���   �$	��100��6A   $��Center=�6M   �� 5P      -   5        $ AppointmentTimeComboBox��5P      $	��200��6@    �� SelectedValuePath$ .��6L   5Q      �� 5R      $ 
Horizontal=�6   $	��0,5q�66   .+�5S      �� $��Статус:��6    
���   �$	��100��6B   $��Center=�6N   �� 5T      -   5        $ StatusComboBox��5T      $	��200��67   5U      �� 5X      $ 
Horizontal=�6   $��Center=�66   $
��0,10q�6S   .+�5Y      �� -   5         ��Name$ UpdateAppointment��5Y      $+��%Сохранить изменения��68   $	��180��5Z      $��5q�6)   ���	#FF0A1129���	#FF050C315[      �� 5\      -   5        $ CancelAppointment��5\      $#��Отменить запись��68   $	��150��5]      $��5q�6)   
���  ��
���  ��
�������5_      5`      5a      5b      5c      5d      