   M S B A M L   `   `   `  ����C  ?Astmara6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Astmara6Con.ControlsAstmara6Con.Controls  5      #clr-namespace:Astmara6Astmara6  5      #    Astmara6Con.Controls.UCMajors   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Astmara6Con.Controls     5      +Astmara6clr-namespace:Astmara6     5      $	��484��5	      $	��746��6     � 	Resources  5
         1  Color1\   Astmara6.Branches  branches  branchesViewSource �� Source �� Source   Astmara6.Section  section  sectionsViewSource��%	  &	        &	 !     &	 B     &	 U     7  &	 �     &	 �     7  ��5   
   	#FF3580BF��6%   ��5   
   	#FFECE3E3��6+     5   
   6   �� 5   
    6:   �� *	_Branches+8     5   
   6   �� 5   
    6:   �� *
Sections+8   5      .��5      �  � DataContext# [ 6   .+�5   
   �� $��اسم القسم��6   $
��Left=�6$   $��658,226,0,0q�6?   $	��Top=�6T   ��6l   Z� ��5      �� 5       �� Color# �   6"   5      �� 5   
   -   5         ��Name$ BTNBack��5      $��عودة��6"   $
��Left=�61   $��	0,421,0,0q�6L   $	��Top=�6_   $��77��6w   $��29��6�   ��5      �� 5      # �   6"   5      �� 5   
   -   5        $ BTNNext��5      $��التالي��6"   $
��Left=�63   $��	0,455,0,0q�6N   $��77��6a   $
��Auto��6l   ��5      �� 5       # �   6"   5"      �� 5#   
   $��اسم الشعبة��6   $
��Left=�6%   $��451,226,0,0q�6@   $	��Top=�6U   ��6m   Z� ��5$      �� 5%      # �   6"   5'      �� 5(   
   -   5         ��Name$ TBNameMajors��5(      $
��Left=�6S   $��30��6n   $��326,226,0,0q�6z    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ���	#FFECE3E3.��6�   ��5)      �� 5*      # �   6"   .��5+   #   5,      �� 5-   
   -   5        $ BTNAdd��5-      $��
اضافة��6!   $��Right=�61   $��0,0,440,230q�6M   $��Bottom=�6b   $��68��6}   $��28��6�   ��5.      �� 5/      # �   6"   51      �� 52   
   -   5         ��Name$ CBNameDepartment��52      	 �� DisplayMemberPath$	 TypeOfBranch��6-   $��28��6N   $��536,226,99,230q�6r   
 �� SelectedValuePath$
 Id��6�   ��6Z   �� ��53      �� 54      .R�55      $� 56      58      &   System.Windows.Controls.DataGrid  59   
   -   5          Name$ DGMajorsView��59      $��RightToLeft=�6)      
IsReadOnly .    AutoGenerateColumns .     EnableRowVirtualization . $��309,286,0,0q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6�   �� # [    Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6=      
IsReadOnly .    
Visibility$ Hidden=�6[      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6o   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6&   �� *Id+6o     5<      $ 	Id Branch��6C   $ Hidden=�6V   $ SizeToHeader 6j    6&   �� *
IdBranch+6j     5=      $ الشعبة��6@   $
 Auto 6P    6&   �� *Name+6P     5>      $ 
القسم��6I   $
 Auto 6X    6&   �� *TypeOfBranch+6X   5B      �� 5C   
   -   5        $ BTNEdit��5C      $��تعديل و حذف��6"   $
��Left=�68   $��432,295,0,0q�6S   $	��Top=�6h   $	��122��6�   $��31��6�   ���	#FF303030���	#FF303030 J� RenderTransformOrigin$ 0.583,1.607&�6�   5G      5H      