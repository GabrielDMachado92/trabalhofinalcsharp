   M S B A M L   `   `   `  ����F  BWPFSolution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFSolutionWPFSolution  5   	        WPFSolution.CadastrarLivro   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFSolution     5   	     � Title$  CadastrarLivro��5   	   $	��350��6    $	��525��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ labelCadastrarLivro��5
      $��Cadastrar Livros��6-   $
��Left=�6H   $��	10,10,0,0q�6c   $	��Top=�6v   $��18(�6�   �� 5   
   -   5        $ labelNomeLivro��5      $
��Nome��6(   $
��Left=�67   $��	10,49,0,0q�6R   $	��Top=�6e   �� 5   
   -   5         ��Name$ textBoxNomeLivro��5      $
��Left=�6,   $��23��6G   $��	65,52,0,0q�6S    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ labelEdicaoLivro��5      $��Edição��6*   $
��Left=�6;   $��	10,80,0,0q�6V   $	��Top=�6i   �� 5   
   -   5         ��Name$ comboBoxEdicaoLivro��5      $
��Left=�60   $��	65,84,0,0q�6K   $	��Top=�6^   $��45��6v   .@�5      �� .��5      �� 16   5      �� 5      .��5      �� 26   5      �� 5      .��5      �� 36   5      �� 5      .��5      �� 46   5      �� 5      .��5      �� 56   5      �� 5      .��5      �� 66   5       �� 5!      .��5"      �� 76   5#      �� 5$      .��5%      �� 86   5&      �� 5'      .��5(      �� 96   5)      �� 5*      .��5+      �� 106    5,      5.      �� 50   
   -   5        $ labelDoadorCadastroLivro��50      $��Doador��62   $
��Left=�6C   $��
10,111,0,0q�6^   $	��Top=�6r   �� 51   
   -   5        $ comboBoxDoadores��51      $
��Left=�6-   $��
65,115,0,0q�6H   $	��Top=�6\   $	��120��6t   53      �� 55   
   -   5        $ labelOngCadastroDoador��55      $	��ONG��60   $
��Left=�6>   $��
10,142,0,0q�6Y   $	��Top=�6m    J� RenderTransformOrigin$ 0.222,0.577&�6�   �� 56   
   -	   5        $ comboBoxOngs��56      $
��Left=�6)   $��
65,146,0,0q�6D   $	��Top=�6X   $	��120��6p   �� 57   
   -
   5         ��Name$ buttonCadastrarLivro��57      $��	Cadastrar��6/   $
��Left=�6C   $��
10,173,0,0q�6^   $	��Top=�6r   $��75��6�   6�   �� 58   
   -   5        $! buttonVoltarCadastrarLivros��58      $��Voltar��66   $
��Left=�6G   $��110,173,0,0q�6b   $	��Top=�6w   $��75��6�   6�   5:      5;      