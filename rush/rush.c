/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   rush.c                                             :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: alexpere <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/07/14 10:39:49 by alexpere          #+#    #+#             */
/*   Updated: 2024/07/14 12:02:57 by alexpere         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */
void	ft_putchar(char c);

void	line(int len, char begin, char mid, char end)
{
	int	i;

	i = 1;
	while (i <= len)
	{
		if (i == 1)
			ft_putchar(begin);
		else if (i > 1 && i < len)
			ft_putchar(mid);
		if (i == len)
			ft_putchar(end);
		i++;
	}
	ft_putchar('\n');
}

void	rush(int x, int y)
{
	int	i;

	i = 1;
	while (i == 1)
	{
		if (i == 1)
			line(x, 'o', '-', 'o');
		else if (i <= (y - 1))
			line(x, '|', ' ', '|');
		if (i >= y)
			line(x, 'o', '-', 'o');
		i++;
	}
}
