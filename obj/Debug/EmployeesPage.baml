   M S B A M L   `   `   `  ����G  CDentalClinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DentalClinicDentalClinic  5           DentalClinic.EmployeesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      &localclr-namespace:DentalClinic  5        N� 
FontFamily$  Bahnschrift)�5	   0    N� Title$ EmployeesPage��5
      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��0,0,0,10q�6;   .+�5      �� -   5         ��Name$ SearchTextBox��5      $	��200��6-   $��0,0,10,0q�69   $��Center=�5   
   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Поиск по имени...��6%   �� 5      -   5         ��Name$ PostFilterComboBox��5      $	��140��63   $��0,0,10,0q�6?   $��Center=�5      $) #Выберите должность��6&   �� 5      -   5        $" SpecializationFilterComboBox��5      $	��170��6=   $��0,0,10,0q�6I   $��Center=�5      $1 +Выберите специализацию��6&   �� 5      -   5        $ RoleFilterComboBox��5      $	��110��63   $��0,0,10,0q�6?   $��Center=�5       $ Выберите роль��6*   �� 5!      -   5        ���#0A1129���	#FF050D3A
�������$��
Найти��5!   U   $	��100��6e   $��Center=�6q   6�   5"      �� 5%   
   $��1��6   $
��Auto=�6$   $
��Auto=�6G   .��5&      &   System.Windows.Controls.DataGrid  -   5          Name$ EmployeesDataGrid��5&   ,   ���#0A1129   AutoGenerateColumns .  	   CanUserAddRows	 .  
   
IsReadOnly
 . $��0,0,0,10q�5'   @    � 	Resources 5(      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%C  '        �� 5)      "  6   .�5*      ��  � ��
 �����67   �� 5+       � ��$ Ubuntu)�67   �� 5,       � ��$
 Bold"�67   �� 5-       � �� �#0A112967   �� 5.       � ��$ Center=�6G   �� 5/       � ��$ Center=�6E   �� 50       � ��$ 10,10q�64   51      52         Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6L      
Foreground
 �����1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *ID+6W     55      $ ФИО��6)   $	 230 6T   
 ����� 66   �� *	full_name+6`     56      $ Должность��6)   $	 150 6U   
 ����� 6<   �� *post+6a     57      $  Специализация��6)   $	 150 6c   
 ����� 6@   �� *specialization+6o     58      $ Роль��6)   $	 110 6P   
 ����� 67   �� *role+6\     59      $ Контакты��6)   $	 150 6_   
 ����� 6;   �� *contact_details+6k     5:      $ Опыт (лет)��6)   $	 100 6\   
 ����� 6=   �� *
experience+6h   5<      5=      �� 5@   
   $��2��6   $ Vertical=�6"   $��0,0,0,10q�69   .+�5A      �� $<��6Добавить/Изменить сотрудника��6   $��16(�6<   $
��Bold"�6J   $��0,0,0,10q�6\   �� 5B      $ Vertical=�6   $	��0,5q�60   .+�5C      �� -   5        $ FullNameTextBox��5C      $ ФИО��63   $	��0,5q�6X   �� 5D      -   5        $ PostComboBox��5D      $ Должность��61   $	��0,5q�6\   �� 5E      -	   5        $ SpecializationComboBox��5E      $  Специализация��6;   $	��0,5q�6j   �� 5F      -
   5        $ RolesComboBox��5F      $ Роль��62   $	��0,5q�6X   �� 5G      -   5        $ ContactTextBox��5G      $ Контакты��62   $	��0,5q�6\   �� 5H      -   5        $ ExperienceTextBox��5H      $ Опыт (лет)��65   $	��0,5q�6a   5I      �� 5J      $ 
Horizontal=�6   $��Right=�62   $
��0,10q�6O   .+�5K      �� -   5        $��Добавить��5K      ���#0A1129���	#FF050D3A
�������$	��100��5L   ,   $��0,0,10,0q�68   6J   �� 5M      -   5        $��Изменить��5M      ���#0A1129���	#FF050D3A
�������$	��100��5N   ,   68   5O      5P      �� 5S   
   $��2��6   $��0,0,0,20q�6"   $ 
Horizontal=�64   $��Bottom=�6M   $
��Left=�6h   .+�5T      �� -   5        $��
Назад��5T      $	��150��6%   ���	#FFB20505���	#FF8104046`   5U      5V      5W      