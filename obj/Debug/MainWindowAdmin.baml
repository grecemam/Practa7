   M S B A M L   `   `   `  ����G  CDentalClinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DentalClinicDentalClinic  5   	   "    DentalClinic.MainWindowAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DentalClinic     5   	     � Title$  MainWindowAdmin��5   	   $	��750��6!   $
��1500��6.    � WindowStartupLocation$ CenterScreen=�6;   $��Bahnschrift)�6`   ���	#FF0A1129.��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���	#FF0A1129$��Stretch=�68   ._�5      � .+�5      �� .+�5      �� $��	MelDental��6    $��18(�61   $
��Bold"�6?   
�������$��	10,20,0,5q�6d   �� 5      
�������$��1��63   $��	0,10,0,10q�6>   9� 5      $��Главная��6   $��16(�60   
����������	#FF0A1129$
��10,5q�6h   .��5      �� .+�5      �� -   5         ��Name$ PatientReportsTb��5   (   $*��$Отчёты по пациентам��6B   $��14(�6]   
�������$
��23,5q�6~   6�   �� 5      -   5        $ ServicesReportsTb��5   (   $&�� Отчёты по услугам��6D   $��14(�6]   
�������$
��23,5q�6~   6�   5      5      9� 5       $��Расписание��6   $��16(�63   
����������	#FF0A1129$
��10,5q�6k   .��5!      �� .+�5"      �� -   5        $ ScheduleEmplTb��5"   (   $'��!Расписание врачей��6@   $��14(�6Y   
�������$
��25,5q�6z   6�   5#      5$      9� 5%      $��Записи��6   $��16(�6/   
����������	#FF0A1129$
��10,5q�6g   .��5&      �� .+�5'      �� -   5        $ ScheduleUsersTb��5'   (   $%��Записи пациентов��6A   $��14(�6Y   
�������$
��25,5q�6z   6�   5(      5)      9� 5*      $��Сотрудники��6   $��16(�63   
����������	#FF0A1129$
��10,5q�6k   .��5+      �� .+�5,      �� -   5        $ 
EmployeeTb��5,   (   $3��-Управление сотрудниками��6<   $��14(�6[   
�������$
��25,5q�6|   6�   5-      5.      9� 5/      $��Материалы��6   $��16(�62   
����������	#FF0A1129$
��10,5q�6j   .��50      �� .+�51      �� -   5        $ CountMaterTb��51   (   $/��)Количество материалов��6>   $��14(�6[   
�������$
��25,5q�6|   6�   52      53      54      55      56      �� 57   
    �� Orientation$ Vertical=�6   $��Center=�6,   $	��Top=�6I   $��	0,670,0,0q�6a   $	��210��6t   .+�58      �� 
�������$��1��6+   $��0,0,5,10q�66   �� 59      $ 
Horizontal=�6   .+�5:      �� -   5        $ NamePatient��5:      $/��)Панель администратора��61   $��14(�6N   
�������$��0,0,5,0q�6o   5;      5<       � 5=   
   -   5          �Name$ 	MainFrame��5=      ���	#FFFFD5B8$��1��6:     � NavigationUIVisibility$ Hidden=�6J   5>      5?      