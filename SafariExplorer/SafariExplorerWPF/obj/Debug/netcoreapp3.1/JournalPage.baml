   M S B A M L   `   `   `  ����L  HSafariExplorerWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SafariExplorerWPFSafariExplorerWPF  5      #    SafariExplorerWPF.JournalPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:SafariExplorerWPF     5        N� Title$  JournalPage��5	      .��5
      �� .+�5       � -   5          �Name$ _journalPage��5   
   � 5      $	��720��6	   $
��1280��6   ��5      �� 5       �� ImageSource$ /BackGround_Savanna.jpg��6   .+�5      �� $��Center=�6   $��0,31,0,0q�6,   $��Journal Records��6>   $
��Wrap=�6U   $	��Top=�6i   $��72(�6�   $��	Castellar)�6�   �� 5      $��Center=�6   $	��398��6,   $��	0,118,0,0q�69   
���   �$	��Top=�6[   $	��692��6s   ��5      �� 5      $ /Paper_Texture.png��6   5      �� 5      -   5         ��Name$ ListBoxAnimals��5      $��300,124,603,211q�6%   ���	#A5FFFFFF6q   �� 5      -   5         ��Name$ BtnOpenAddWindow��5      $	��Add��6&   $
��Left=�64   $��275,562,0,0q�6O   $	��Top=�6d   $��88��6|   $	��143��6�   ���	#4C000000$��Freestyle Script)�6�   $��48(�6�   ��5      �� 5      $ /Paper_Texture.png��6   5      �� 5      -   5         ��Name$ 	LabelName��5      $��Animal Name��6   $
��Left=�64   $��682,181,0,0q�6O   $	��Top=�6d   $��51��6|   $	��153��6�   $��36(�6�   
���   ����	#4C000000$��Freestyle Script)�6�   �� 5      -   5        $ 	LabelDiet��5      $
��Diet��6   $
��Left=�6-   $��682,237,0,0q�6H   $	��Top=�6]   $��51��6u   $	��153��6�   $��36(�6�   ���	#4C000000$��Freestyle Script)�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6,   .��5       �  � Color$ Black��6   � 5!      $ White��6   	 � Offset$	 1Q�6#   5"      5$      �� 5%      -   5        $ LabelHeight��5%      $��
Height (m)��6    $
��Left=�65   $��682,292,0,0q�6P   $	��Top=�6e   $��51��6}   $	��153��6�   $��36(�6�   ���	#4C000000$��Freestyle Script)�6�   ��5&      �� 5'      $ 0.5,1&�6   $ 0.5,0&�6,   .��5(      � $ Black��6   � 5)      $ White��6   $	 1Q�6#   5*      5,      �� 5-      -   5        $ LabelLifeSpan��5-      $��Lifespan (yrs)��6"   $
��Left=�6;   $��682,347,0,0q�6V   $	��Top=�6k   $��51��6�   $	��153��6�   $��36(�6�   ���	#4C000000$��Freestyle Script)�6�   ��5.      �� 5/      $ 0.5,1&�6   $ 0.5,0&�6,   .��50      � $ Black��6   � 51      $ White��6   $	 1Q�6#   52      54      �� 55      -   5        $ 	LabelMass��55      $��	Mass (kg)��6   $
��Left=�62   $��682,403,0,0q�6M   $	��Top=�6b   $��51��6z   $	��153��6�   $��36(�6�   ���	#4C000000$��Freestyle Script)�6�   ��56      �� 57      $ 0.5,1&�6   $ 0.5,0&�6,   .��58      � $ Black��6   � 59      $ White��6   $	 1Q�6#   5:      5<      �� 5=      -	   5        $ 
LabelSpeed��5=      $��Speed (km/h)��6   $
��Left=�66   $��682,458,0,0q�6Q   $	��Top=�6f   $��51��6~   $	��153��6�   $��36(�6�   ���	#4C000000$��Freestyle Script)�6�   ��5>      �� 5?      $ 0.5,1&�6   $ 0.5,0&�6,   .��5@      � $ Black��6   � 5A      $ White��6   $	 1Q�6#   5B      5D      �� 5E      -
   5        
 ��Name$
 TextBoxName��5E      $
��Left=�6"   $��835,181,0,0q�6=    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��142��6~   $��51��6�   $��20(�6�   ���	#D8F1F8E86�   �� 5F      -   5        $
 TextBoxDiet��5F      $
��Left=�6"   $��835,237,0,0q�6=   $
 Wrap=�6R   $	��Top=�6f   $	��142��6~   $��51��6�   $��20(�6�   ���	#D8F1F8E86�   �� 5G      -   5        $
 TextBoxHeight��5G      $
��Left=�6$   $��835,292,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��142��6�   $��51��6�   $��20(�6�   ���	#D8F1F8E86�   �� 5H      -   5        $
 TextBoxLifespan��5H      $
��Left=�6&   $��835,347,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��142��6�   $��51��6�   $��20(�6�   ���	#D8F1F8E86�   �� 5I      -   5        $
 TextBoxMass��5I      $
��Left=�6"   $��835,403,0,0q�6=   $
 Wrap=�6R   $	��Top=�6f   $	��142��6~   $��51��6�   $��20(�6�   ���	#D8F1F8E86�   �� 5J      -   5        $
 TextBoxSpeed��5J      $
��Left=�6#   $��835,458,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��142��6   $��51��6�   $��20(�6�   ���	#D8F1F8E86�   �� 5K      -   5        $ 	BtnUpdate��5K      $��Update��6   $
��Left=�60   $��678,562,0,0q�6K   $	��Top=�6`   $��88��6x   $	��143��6�   ���	#4C000000$��Freestyle Script)�6�   $��48(�6�   ��5L      �� 5M      $ /Paper_Texture.png��6   5O      �� 5P      -   5        $ Labelid��5P      $��ID��6   $
��Left=�6)   $��682,126,0,0q�6D   $	��Top=�6Y   $��51��6q   $	��153��6}   $��36(�6�   
���   ����	#4C000000$��Freestyle Script)�6�   �� 5Q      -   5        $
 	TextBoxID��5Q      $
��Left=�6    $��835,126,0,0q�6;   $
 Wrap=�6P   $	��Top=�6d   $	��142��6|   $��51��6�   $��20(�6�   ${�False��6�   �� 5R      -   5        $ 
BtnRefresh��5R      $��Refresh��6    $
��Left=�62   $��470,562,0,0q�6M   $	��Top=�6b   $��88��6z   $	��143��6�   ���	#4C000000$��Freestyle Script)�6�   $��48(�6�   ��5S      �� 5T      $ /Paper_Texture.png��6   5V      �� 5W      -   5        $ 	BtnDelete��5W      $��Delete��6   $
��Left=�60   $��88��6K   $��881,562,0,0q�6W   $	��Top=�6l   $	��143��6�   ���	#4C000000$��Freestyle Script)�6�   $��48(�6�   ��5X      �� 5Y      $ /Paper_Texture.png��6   5[      �� 5\      -   5        $ BtnBack��5\      $
��Back��6   $
��Left=�6,   $��	10,19,0,0q�6G   $	��Top=�6Z   $��70��6r   $��75��6~   ���	#7F000604$��24(�6�   ���	#B2BCEABC��6�   Z� 6�   5^      5b      5d      